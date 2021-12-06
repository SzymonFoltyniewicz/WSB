import random
def print_board(board, size):
    rows = ["" for i in range(size)]
    for i in range(size):
        rows[i] = ["| {" + board[i][j] + "} " for j in range(size)]
        rows[i] += "|"

    for i in range(size):
        tempRow = ""
        for j in range(size + 1):
            tempRow += rows[i][j]
            if j == size:
                print(tempRow)
# done
def is_victory(sign, board, size):
    for i in range(size):
        signAmount = 0
        for j in range(size):
            if board[i][j] == sign: signAmount += 1
            if signAmount == size: return True
    for i in range(size):
        signAmount = 0
        for j in range(size):
            if board[j][i] == sign: signAmount += 1
            if signAmount == size: return True
    signAmount = 0
    for i in range(size):
        if board[i][i] == sign: signAmount += 1
        if signAmount == size: return True
    signAmount = 0
    for i in range(size):
        if board[i][size - i - 1] == sign: signAmount += 1
        if signAmount == size: return True

# done
    
def is_draw(board):
    fullRows = 0
    for i in range(len(board)):
        if "  " not in board[i]:
            fullRows += 1
    if fullRows == len(board):
        return True
    else: return False
# done

def player_move(sign, board, size):

    if sign == "X":
        number = 1
    elif sign == "O":
        number = 2
    print("Twój ruch graczu numer {}".format(number))
    while True: 
        try:

                choiceX = int(input("Podaj współrzędną x znaczka(0-"+str(size-1)+"): "))
                choiceY = int(input("Podaj współrzędną y znaczka(0-"+str(size-1)+"): "))
                if board[choiceX][choiceY] == "  " and (choiceX < size and choiceX >= 0) and (choiceY < size and choiceY >= 0):
                     board[choiceX][choiceY] = sign
                     break
                else:
                    print()
                    print("To miejsce jest zajęte!")
        except:
            print("Podana wartość nie jest odpowiednią liczbą")
# done

def random_move(board, size):
    while True:
        x = random.randint(0,size-1)
        y = random.randint(0,size-1)
        if board[x][y] == "  ":
            board[x][y] = "O"
            return False
# done
def step1(sign, board, size):
    solution = [0,0]
    for i in range(size):
        points = 0
        for j in range(size):
            if board[i][j] == sign:
                points += 1
            elif board[i][j] == "  ":
                solution[0] = i
                solution[1] = j
            if points == size - 1 and board[solution[0]][solution[1]] == "  " and j == size-1:
                board[solution[0]][solution[1]] = "O"
                return False
    return True
# done
def step2(sign, board, size):
    solution = [0,0]
    for i in range(size):
        points = 0
        for j in range(size):
            if board[j][i] == sign:
                points += 1
            elif board[j][i] == "  ":
                solution[0] = j
                solution[1] = i
            if points == size - 1 and board[solution[0]][solution[1]] == "  " and j == size-1:
                board[solution[0]][solution[1]] = "O"
                return False
    return True
#done
def step3(sign, board, size):
    solution = [0,0]
    points = 0
    for i in range(size):
            if board[i][i] == sign:
                points += 1
            elif board[i][i] == "  ":
                solution[0] = i
                solution[1] = i
    if points == size - 1 and board[solution[0]][solution[1]] == "  ":
        board[solution[0]][solution[1]] = "O"
        return False
    return True
#done
def step4(sign, board, size):
    solution = [0,0]
    points = 0
    for i in range(size):
            if board[i][size - i - 1] == sign:
                points += 1
            elif board[i][size - i - 1] == "  ":
                solution[0] = i
                solution[1] = size - i - 1
    if points == size - 1 and board[solution[0]][solution[1]] == "  ":
        board[solution[0]][solution[1]] = "O"
        return False
    return True

def bot_logic(sign, board,size):
    nextStep = step1(sign, board, size)
    if nextStep: nextStep = step2(sign, board, size)
    if nextStep: nextStep = step3(sign, board, size)
    if nextStep: nextStep = step4(sign, board, size)
    if sign == "X" and nextStep:
        nextStep = random_move(board, size)
    return nextStep


def bot_move(board,size):
    print("Ruch bota")
    if bot_logic("O",board,size):
        bot_logic("X",board,size)



def play(gameMode, size):
    while True:
        board = ["  " for i in range(size)]
        for i in range(size):
            board[i] = ["  " for i in range(size)]
        while True:

            print_board(board, size)
            player_move("X",board,size)
            print_board(board, size)

            if is_victory("X",board,size):
                print("Zwyciężył X!")
                break
            elif is_draw(board):
                print("Remis!")
                break

            if gameMode == 2: player_move("O",board,size)
            else: bot_move(board,size)

            if is_victory("O",board,size):
                print_board(board, size)
                print("Zwyciężył O!")
                break
            elif is_draw(board):
                print("Remis!")
                break
        nextGame = input("Jeśli chcesz grać dalej, wpisz 'T': ")
        if nextGame == 'T':
            continue
        else: break

# done
print("Wybierz jedną z opcji")
print("1 - gra z botem")
print("2 - gra z drugim graczem")
playMode = input(": ")
size = input("Podaj rozmiar planszy (x na x):")
try:
    playMode = int(playMode)
    size = int(size)
except:
    print("Wprowadzona wartość nie jest liczbą")
if size >= 2:
    if playMode == 1 or playMode == 2: play(playMode, size)
else: print("Minimapna wielkość planszy to 2 na 2")





    

    

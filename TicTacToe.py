board = ["  " for i in range(9)]

def clear_board():
    for i in range(9):
        board[i] = "  "

def print_board():
    row1 = "| {} | {} | {} |".format(board[0], board[1], board[2])
    row2 = "| {} | {} | {} |".format(board[3], board[4], board[5])
    row3 = "| {} | {} | {} |".format(board[6], board[7], board[8])

    print()
    print(row1)
    print(row2)
    print(row3)
    print()

def is_victory(sign):
    if (board[0] == sign and board[1] == sign and board[2] == sign) or \
       (board[3] == sign and board[4] == sign and board[5] == sign) or \
       (board[6] == sign and board[7] == sign and board[8] == sign) or \
       (board[0] == sign and board[3] == sign and board[6] == sign) or \
       (board[1] == sign and board[4] == sign and board[7] == sign) or \
       (board[2] == sign and board[5] == sign and board[8] == sign) or \
       (board[0] == sign and board[4] == sign and board[8] == sign) or \
       (board[2] == sign and board[4] == sign and board[6] == sign):
        return True
    else:
        return False
    
def is_draw():
    if "  " not in board:
        return True
    else:
        return False


def player_move(sign):

    if sign == "X":
        number = 1
    elif sign == "O":
        number = 2

    print("Twój ruch graczu numer {}".format(number))
    while True: 
        try:

                choice = int(input("Wybierz pole na które chcesz wprowadzić twój znaczek (1-9): ").strip())
                if board[choice -1] == "  " and (choice < 10 and choice > 0):
                     board[choice -1] = sign
                     break
                else:
                    print()
                    print("To miejsce jest zajęte!")
        except:
            print("Podana wartość nie jest odpowiednią liczbą")

def bot_logic(sign):
    if board[0] == sign and board[2] == sign and board[1] == "  ": choice = 1
    elif board[0] == sign and board[1] == sign and board[2] == "  ": choice = 2
    elif board[1] == sign and board[2] == sign and board[0] == "  ": choice = 0
    # ===
    elif board[3] == sign and board[4] == sign and board[5] == "  ": choice = 5
    elif board[5] == sign and board[4] == sign and board[3] == "  ": choice = 3
    elif board[5] == sign and board[3] == sign and board[4] == "  ": choice = 4
    # ===
    elif board[6] == sign and board[7] == sign and board[8] == "  ": choice = 8
    elif board[7] == sign and board[8] == sign and board[6] == "  ": choice = 6
    elif board[6] == sign and board[8] == sign and board[7] == "  ": choice = 7
    # ===
    elif board[0] == sign and board[3] == sign and board[6] == "  ": choice = 6
    elif board[0] == sign and board[6] == sign and board[3] == "  ": choice = 3
    elif board[3] == sign and board[6] == sign and board[0] == "  ": choice = 0
    # |||
    elif board[1] == sign and board[4] == sign and board[7] == "  ": choice = 7
    elif board[1] == sign and board[7] == sign and board[4] == "  ": choice = 4
    elif board[7] == sign and board[4] == sign and board[1] == "  ": choice = 1
    # |||
    elif board[2] == sign and board[5] == sign and board[8] == "  ": choice = 8
    elif board[5] == sign and board[8] == sign and board[2] == "  ": choice = 2
    elif board[2] == sign and board[8] == sign and board[5] == "  ": choice = 5
    # |||
    elif board[0] == sign and board[4] == sign and board[8] == "  ": choice = 8
    elif board[4] == sign and board[8] == sign and board[0] == "  ": choice = 0
    elif board[8] == sign and board[0] == sign and board[4] == "  ": choice = 4
    # \\\
    elif board[2] == sign and board[4] == sign and board[6] == "  ": choice = 6
    elif board[6] == sign and board[4] == sign and board[2] == "  ": choice = 2
    elif board[2] == sign and board[6] == sign and board[4] == "  ": choice = 4
    # ///
    else:
        choice = 9
    return choice



def bot_move(sign):
    print("Ruch bota")
    choice = bot_logic("O")
    if choice == 9: choice = bot_logic("X")
    if choice == 9 and board[4] == "  ":
        choice = 4
    if choice == 9:
        for i in range(len(board)):
            if board[i] == "  ":
                choice = i
                break
    board[choice] = sign


def play(gameMode):
    while True:
        clear_board()
        while True:

            print_board()
            player_move("X")
            print_board()

            if is_victory("X"):
                print("Zwyciężył X!")
                break
            elif is_draw():
                print("Its a draw!")
                break

            if gameMode == 2: player_move("O")
            else: bot_move("O")

            if is_victory("O"):
                print_board()
                print("Zwyciężył O!")
                break
            elif is_draw():
                print("Remis!")
                break
        nextGame = input("Jeśli chcesz grać dalej, wpisz 'T': ")
        if nextGame == 'T':
            continue
        else: break


print("Wybierz jedną z opcji")
print("1 - gra z botem")
print("2 - gra z drugim graczem")
playMode = input(": ")
try:
    playMode = int(playMode)
except:
    print("Wprowadzona wartość nie jest liczbą")
if playMode == 1 or playMode == 2: play(playMode)

input("...")




    

    

<!DOCTYPE HTML>
<html lang="pl">

<head>
    <meta charset="utf8" />
    <title>Szyfrowanie Cezara</title>
</head>

<body>
    <h1>
        Szyfr Cezara
    </h1>
    <h2>TEKST</h2>
    <form method="post">
        <textarea cols="20" rows="20" name="data"></textarea>
        <br><br>
        <h3>PRZESUNIECIE</h3>
        <input type="number" name="numdat" />
        <input type="submit" value="Wyślij" />
    </form>
    <br><br>

    <?php
@$data = $_POST['data'];
@$numb = $_POST['numdat'];
 $array = array();

for($i=0;$i<strlen($data);$i++)
{
	array_push($array,$data[$i]);
}

if($numb>=0)
{
	for($i =0;$i < count($array);$i++)
	{
		if($array[$i]==" " || $array[$i]=="."||$array[$i]=="!"||$array[$i]=="?")
		{
			continue;
		}
			for($j=0;$j<$numb;$j++)
			{
				if($array[$i]=="z")
				{
					$array[$i]="a";
				}
				else if($array[$i]=="Z")
				{
					$array[$i]="A";
				}
				else 
				{
					$array[$i]++;
				}
			}
	}
}
else
{
	for($i =0;$i < count($array);$i++)
	{
		if($array[$i]==" " || $array[$i]=="."||$array[$i]=="!"||$array[$i]=="?")
		{
			continue;
		}
			for($j=0;$j>$numb;$j--)
			{
				if($array[$i]=="a")
				{
					$array[$i]="z";
				}
				else if($array[$i]=="A")
				{
					$array[$i]="Z";
				}
				else 
				{
				$temp = ord($array[$i]);
				$temp--;
				$array[$i] =chr($temp);
				}
			}
	}
}



foreach($array as $value)
{
	print($value);
}


?>

</body>

</html>

<?php

    $username;
    $password;

    $deine_Id;

   if(strlen($_POST['user']) > 3 && strlen($_POST['passus']) > 4)
   {
        $username = $_POST['user'];
        $password = $_POST['passus'];
        include('connector.php');

        //definiere deinen Abfrage-String
        $gebMirDieUserID = 'SELECT `users_id` from users where username="'.$username.'" and password="'.$password.'"';

        //dann mache die Abfrage mit einem Query
        $query = mysqli_query($conn, $gebMirDieUserID);

        //danach muss das "Ergebnis" auseinader genommen werden
        $result = mysqli_fetch_assoc($query);

        $deine_Id = $result['users_id'];
        mysqli_close($conn);
   }
   else
   {
        header("Location:http://localhost/matratzenfinder");
   }
?>

<html>
    <head>
        <link rel="stylesheet" href="styles/style.css" />
    </head>
    <body>
        <h1>umfrage</h1>
        
        <?php
            //echo("<p>das hast du eingegeben:".$a."</p>");
        ?>
        <?php            
            echo("<p>du hast die ID mit der Nummer: ".$deine_Id);
        ?>
    </body>
</html>

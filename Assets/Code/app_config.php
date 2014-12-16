<?PHP
    define('DB_USER','User');
    define('DB_PASSWORD','');
    define('DB_ADRESS','localhost');
    define('DB_DB','dgnu');

    function connect()
    {
        mysql_connect(DB_ADRESS,DB_USERNAME,DB_PASSWORD) or die('ERRO : ' .mysql_error());
        mysql_select_db(DB_DB) or die('ERRO : ' .mysql_error());
    }
?>
<?PHP
    require_once 'app_config.php';
    connect();
    
    $query = 'Select * from score order by score.Score desc limit 10';
    $result = mysql_query($query) or die ('ERRO : ' .mysql_error());
    while($item = mysql_fetch_array($result))
    {
        echo $item['Nome'] . ' - ' . $item['Score'] . '</br>'; 
    }
?>
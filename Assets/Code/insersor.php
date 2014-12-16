<?PHP
    require_once 'app_config.php';
    connect();
    
    $Nome = $_GET['name'];
    $Score = $_GET['score'];

    $query = 'insert into score(score.Nome, score.Score) values('.$Nome.','.$Score.')';
    $result = mysql_query($query) or die ('ERRO : ' .mysql_error());
?>
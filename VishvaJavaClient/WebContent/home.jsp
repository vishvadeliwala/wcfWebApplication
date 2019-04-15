<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Home</title>
        <style>
            div{
                font-size: 50px;
                background-color:rgba(255, 204, 153,0.5);
                width: 850px;
            }   
            
            p{
                padding:20px;
                position:relative;
                background: rgba(255, 204, 153,0.5);
                width: 500px;
                height:300px;
                font-size: 25px;
            }
            input{
                font-size: 25px;
            }
        </style>

</head>
<body style="background-image: url('images/libraryimage.jpeg');">
<div style="margin-left: 250px">
                LIBRARY MANAGEMENT SYSTEM
            </div>
            <br>
            <br>
            <form action="HomeServlet" method="post">
            <p style="margin-left: 400px">
                To Add, Update, Delete Books login here:<br><br>
            
                Username:<input type='text' name="uname"/><br><br>
                Password:<input type="password" name='pass'/><br><br>
            <input style="background-color:rgb(234,119,15)" type ="submit" value="Login"/><br><br>
            </p>
            </form>
            <!-- form action="search.jsp">-->
            <p style="margin-left:400px">           
             To Search Books Click here:<br><br>
             
             <a href="/VishvaJavaClient/searchByName.jsp">Search Book By Book Name</a>
               <br>
                <a href="/VishvaJavaClient/searchByAuthor.jsp">Search Book By Author Name</a>
               <br>
                <a href="/VishvaJavaClient/searchByGenre.jsp">Search Book By Genre</a>
                <br>
                 <a href="showAllBooks">Show All Books</a>
               <br>
            <!-- <input style="background-color:rgb(234,119,15)" type="submit" value="Search Books" /><br><br>-->
            <br>
            </p>
        
</body>
</html>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html style="background-image: url('images/libraryimage.jpeg');">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Admin</title>
        <style>
            p{
                font-size: 50px;
                background-color:rgba(255, 204, 153,0.5);
                width: 350px;
            }   
            
            div{
            	background-color:rgba(255, 204, 153,0.5);
            	width: 600px;
            }
            
            input{
                font-size: 25px;
            }
        </style>
    </head>
    <body>
        <p style="margin-left: 500px">
                ADMIN PAGE
            </p>
            <div>
         <form action="/AdminServlet" method="post">
           <!-- <p style="margin-left: 400px"> 
                Book Id: <input type="textbox" name="bookid" id="bookid"/><br><br>
                Book Name: <input type="textbox" name="bookname" id="bookname"/><br><br>
                Author: <input type="textbox" name="author" id="author"/><br><br>
                Genre: <input type="textbox" name="genre" id="genre"/><br><br>
                Number Of Books:</td><td> <input type="textbox" name="num" id="num"/><br><br><br>-->
            
               <h1> Select your Choice:<br><br>
                <a href="/VishvaJavaClient/addBook.jsp">Add Book</a>
                <a href="/VishvaJavaClient/updateBook.jsp">Update Book</a>
                <a href="/VishvaJavaClient/deleteBook.jsp">Delete Book</a></h1>
                <!-- input style="background-color:rgb(234,119,15)" type="submit" name="add" value="Add Book"/></a>&nbsp;&nbsp;&nbsp;
                <input style="background-color:rgb(234,119,15)" type="submit" name="update" value="Update Book"/>&nbsp;&nbsp;&nbsp;
                <input style="background-color:rgb(234,119,15)" type="submit" name="delete" value="Delete Book"/>-->
            
        </form>
        </div>
    </body>
</html>

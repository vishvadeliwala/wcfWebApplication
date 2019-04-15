<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html style="background-image: url('images/libraryimage.jpeg');">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Admin</title>
        <style>
            div{
                font-size: 50px;
                background-color:rgba(255, 204, 153,0.5);
                width: 350px;
            }   
            
            p{
                padding:20px;
                position:relative;
                background: rgba(255, 204, 153,0.5);
                width: 500px;
                height:500px;
                font-size: 25px;
            }
            input{
                font-size: 25px;
            }
        </style>
    </head>
    <body>
        <div style="margin-left: 500px">
                Search Book 
            </div>
         <form action="searchByAuthor" method="post">
            <p style="margin-left: 400px"> 
                Author Name: <input type="text" name="authorname" id="authorname"/><br><br>	
                <!-- Book Name: <input type="text" name="bookname" id="bookname"/><br><br>
                Author: <input type="text" name="author" id="author"/><br><br>
                Genre: <input type="text" name="genre" id="genre"/><br><br>
                Number Of Books:</td><td> <input type="text" name="num" id="num"/><br><br><br>
            
                Select your Choice:<br><br>
                <!-- <a href="/VishvaJavaClient/addBook.jsp">Add Book</a>
                <a href="updateBook">Update Book</a>
                <a href="deleteBook">Delete Book</a>-->
                <input style="background-color:rgb(234,119,15)" type="submit" name="add" value="Search"/>&nbsp;&nbsp;&nbsp;
                <!-- <input style="background-color:rgb(234,119,15)" type="submit" name="update" value="Update Book"/>&nbsp;&nbsp;&nbsp;
                <input style="background-color:rgb(234,119,15)" type="submit" name="delete" value="Delete Book"/>-->
            </p>
        </form>
    </body>
</html>

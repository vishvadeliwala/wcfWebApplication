<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ page import="org.datacontract.schemas._2004._07.WcfService1.Book" %>
<!DOCTYPE html>
<html style="background-image: url('images/libraryimage.jpeg');">
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
<style>
	table {
		background-color:rgba(255, 204, 153,0.5);
	}
</style>
</head>
<body>
<table >
	<%
		Book[] book = (Book[])request.getAttribute("book");
		%>
		<hr>
		<th>
				<h2>Book Id</h2>
			</th>
			<th>
				<h2>Book Name</h2>
			</th>
			<th>
				<h2>Author</h2>
			</th>
			<th>
				<h2>Genre</h2>
			</th>
			<th>
				<h2>Number Of Book</h2>
			</th>
			
		</hr>
		<%
		for(int i=0;i<book.length;i++)
		{
			%>
			<tr>
			<%
			Integer bookid = book[i].getBookID();
			String bookname = book[i].getBookName();
			String bookauthor = book[i].getBookAuthor();
			String genre = book[i].getBookGenre();
			Integer num = book[i].getBookNumber();
			%>
			<td>
				<h3 align="center"><% out.print(bookid); %></h3>  
			</td>
			<td>
				<h3 align="center"><% out.print(bookname); %></h3>  
			</td>
			<td>
				<h3 align="center"><% out.print(bookauthor); %></h3>  
			</td>
			<td>
				<h3 align="center"><% out.print(genre); %></h3>  
			</td>
			<td>
				<h3 align="center"><% out.print(num); %></h3>  
			</td>
			
							
				
			</tr>
			<%} %>		

	</table>
	
</div>
	
</body>
</html>


import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.tempuri.IService1Proxy;

/**
 * Servlet implementation class updateBook
 */
@WebServlet("/updateBook")
public class updateBook extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public updateBook() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		doPost(request,response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		Integer bookid = Integer.parseInt(request.getParameter("bookid"));
		String bookname = (String)request.getParameter("bookname");
		String author = (String)request.getParameter("author");
		String genre = (String)request.getParameter("genre");
		Integer num = Integer.parseInt(request.getParameter("num"));
		
		IService1Proxy proxy = new IService1Proxy();
		Integer result=proxy.updateBook(bookid, bookname, author, genre, num);
		if(result==1)
		{
			RequestDispatcher rd = request.getRequestDispatcher("showAllBooks");
		rd.forward(request, response);
		}
	}

}

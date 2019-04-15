

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.tempuri.IService1Proxy;

/**
 * Servlet implementation class searchByGenre
 */
@WebServlet("/searchByGenre")
public class searchByGenre extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public searchByGenre() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
		doPost(request,response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		String genre = (String)request.getParameter("genre");
		IService1Proxy proxy = new IService1Proxy();
		//IService1Proxy proxy = new IService1Proxy();
		org.datacontract.schemas._2004._07.WcfService1.Book[] book = proxy.getBooksByGenre(genre);
		request.setAttribute("book", book);
		RequestDispatcher rd = request.getRequestDispatcher("showAllBooks.jsp");
		rd.forward(request, response);
	}

}

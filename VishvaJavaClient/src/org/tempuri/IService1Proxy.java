package org.tempuri;

public class IService1Proxy implements org.tempuri.IService1 {
  private String _endpoint = null;
  private org.tempuri.IService1 iService1 = null;
  
  public IService1Proxy() {
    _initIService1Proxy();
  }
  
  public IService1Proxy(String endpoint) {
    _endpoint = endpoint;
    _initIService1Proxy();
  }
  
  private void _initIService1Proxy() {
    try {
      iService1 = (new org.tempuri.Service1Locator()).getBasicHttpBinding_IService1();
      if (iService1 != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iService1)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iService1)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iService1 != null)
      ((javax.xml.rpc.Stub)iService1)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.IService1 getIService1() {
    if (iService1 == null)
      _initIService1Proxy();
    return iService1;
  }
  
  public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooks() throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getBooks();
  }
  
  public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByName(java.lang.String name) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getBooksByName(name);
  }
  
  public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByAuthor(java.lang.String author) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getBooksByAuthor(author);
  }
  
  public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByGenre(java.lang.String genre) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getBooksByGenre(genre);
  }
  
  public java.lang.Integer addBook(java.lang.Integer id, java.lang.String name, java.lang.String author, java.lang.String genre, java.lang.Integer num) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.addBook(id, name, author, genre, num);
  }
  
  public java.lang.Integer deleteBook(java.lang.Integer id) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.deleteBook(id);
  }
  
  public java.lang.Integer updateBook(java.lang.Integer id, java.lang.String name, java.lang.String author, java.lang.String genre, java.lang.Integer num) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.updateBook(id, name, author, genre, num);
  }
  
  
}
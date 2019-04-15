/**
 * IService1.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IService1 extends java.rmi.Remote {
    public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooks() throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByName(java.lang.String name) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByAuthor(java.lang.String author) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.WcfService1.Book[] getBooksByGenre(java.lang.String genre) throws java.rmi.RemoteException;
    public java.lang.Integer addBook(java.lang.Integer id, java.lang.String name, java.lang.String author, java.lang.String genre, java.lang.Integer num) throws java.rmi.RemoteException;
    public java.lang.Integer deleteBook(java.lang.Integer id) throws java.rmi.RemoteException;
    public java.lang.Integer updateBook(java.lang.Integer id, java.lang.String name, java.lang.String author, java.lang.String genre, java.lang.Integer num) throws java.rmi.RemoteException;
}

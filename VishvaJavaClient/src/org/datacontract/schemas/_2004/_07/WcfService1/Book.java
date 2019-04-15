/**
 * Book.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.WcfService1;

public class Book  implements java.io.Serializable {
    private java.lang.String bookAuthor;

    private java.lang.String bookGenre;

    private java.lang.Integer bookID;

    private java.lang.String bookName;

    private java.lang.Integer bookNumber;

    public Book() {
    }

    public Book(
           java.lang.String bookAuthor,
           java.lang.String bookGenre,
           java.lang.Integer bookID,
           java.lang.String bookName,
           java.lang.Integer bookNumber) {
           this.bookAuthor = bookAuthor;
           this.bookGenre = bookGenre;
           this.bookID = bookID;
           this.bookName = bookName;
           this.bookNumber = bookNumber;
    }


    /**
     * Gets the bookAuthor value for this Book.
     * 
     * @return bookAuthor
     */
    public java.lang.String getBookAuthor() {
        return bookAuthor;
    }


    /**
     * Sets the bookAuthor value for this Book.
     * 
     * @param bookAuthor
     */
    public void setBookAuthor(java.lang.String bookAuthor) {
        this.bookAuthor = bookAuthor;
    }


    /**
     * Gets the bookGenre value for this Book.
     * 
     * @return bookGenre
     */
    public java.lang.String getBookGenre() {
        return bookGenre;
    }


    /**
     * Sets the bookGenre value for this Book.
     * 
     * @param bookGenre
     */
    public void setBookGenre(java.lang.String bookGenre) {
        this.bookGenre = bookGenre;
    }


    /**
     * Gets the bookID value for this Book.
     * 
     * @return bookID
     */
    public java.lang.Integer getBookID() {
        return bookID;
    }


    /**
     * Sets the bookID value for this Book.
     * 
     * @param bookID
     */
    public void setBookID(java.lang.Integer bookID) {
        this.bookID = bookID;
    }


    /**
     * Gets the bookName value for this Book.
     * 
     * @return bookName
     */
    public java.lang.String getBookName() {
        return bookName;
    }


    /**
     * Sets the bookName value for this Book.
     * 
     * @param bookName
     */
    public void setBookName(java.lang.String bookName) {
        this.bookName = bookName;
    }


    /**
     * Gets the bookNumber value for this Book.
     * 
     * @return bookNumber
     */
    public java.lang.Integer getBookNumber() {
        return bookNumber;
    }


    /**
     * Sets the bookNumber value for this Book.
     * 
     * @param bookNumber
     */
    public void setBookNumber(java.lang.Integer bookNumber) {
        this.bookNumber = bookNumber;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Book)) return false;
        Book other = (Book) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.bookAuthor==null && other.getBookAuthor()==null) || 
             (this.bookAuthor!=null &&
              this.bookAuthor.equals(other.getBookAuthor()))) &&
            ((this.bookGenre==null && other.getBookGenre()==null) || 
             (this.bookGenre!=null &&
              this.bookGenre.equals(other.getBookGenre()))) &&
            ((this.bookID==null && other.getBookID()==null) || 
             (this.bookID!=null &&
              this.bookID.equals(other.getBookID()))) &&
            ((this.bookName==null && other.getBookName()==null) || 
             (this.bookName!=null &&
              this.bookName.equals(other.getBookName()))) &&
            ((this.bookNumber==null && other.getBookNumber()==null) || 
             (this.bookNumber!=null &&
              this.bookNumber.equals(other.getBookNumber())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getBookAuthor() != null) {
            _hashCode += getBookAuthor().hashCode();
        }
        if (getBookGenre() != null) {
            _hashCode += getBookGenre().hashCode();
        }
        if (getBookID() != null) {
            _hashCode += getBookID().hashCode();
        }
        if (getBookName() != null) {
            _hashCode += getBookName().hashCode();
        }
        if (getBookNumber() != null) {
            _hashCode += getBookNumber().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Book.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "Book"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("bookAuthor");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "BookAuthor"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("bookGenre");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "BookGenre"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("bookID");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "BookID"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("bookName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "BookName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("bookNumber");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/WcfService1", "BookNumber"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}

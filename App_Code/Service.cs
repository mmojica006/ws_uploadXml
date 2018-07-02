using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

[WebService(Namespace = "http://crediexpress.com.ni/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    #region DECLARACIONES
    private string Usuario;
    private string password;

    SqlHelper helper = new SqlHelper();

    tbl_remesasDTO remesasDTO = new tbl_remesasDTO();
    #endregion
    
    #region CONSTRUCTOR
    public Service () {     
        this.Usuario = ConfigurationManager.AppSettings["userWS"];
        this.password = ConfigurationManager.AppSettings["passWS"];
    }
    #endregion

    #region EXEPTION PERSONALIZADA

    #endregion
    ;
    #region METODOS
    [WebMethod]
    public DataTable ReceiveData(string oTrama, string oUser, string oPassword)
    {
        string fileName = string.Empty;
        List<string> email = new List<string>();
        email.Add("moises.mojica@crediexpress.com.ni");

        helper.sendEmail("jose.chevez@crediexpress.com.ni", "12244896Jagnika*", email, "TEST", "Hola mundo");

              
        try
        {
            if ((oUser == this.Usuario) && (oPassword == this.password))
            {
                //oTrama = HttpContext.Current.Server.MapPath("~/File/Envio_3780476255.xml");
                //oTrama = "<ProductInfo><Product><Name>Test1</Name><index>0</index></Product><Product><Name>Test2</Name><index>1</index></Product><Product><Name>Test3</Name><index>2</index></Product></ProductInfo>";

                XDocument xDoc = XDocument.Parse(oTrama);
                fileName= StoreXML(oTrama);
                remesasDTO.saveXmlToBd( oUser, fileName);
                // saveToBD(oTrama);
                return new DataTable("Data");
            }
            else
            {

                //  loginExeption exUser = new loginExeption("Error de Usuario");
                CustomeExeption exVal = new CustomeExeption("Error de Usuario");
                ExceptionLogging.SendErrorToText(exVal, true);
                return null;
            }             

        }
        catch (Exception ex)
        {
            ExceptionLogging.SendErrorToText(ex,false);
            return new DataTable("Data");

        }
    }

  
    private void StoreData(string data, string oUser, string oPassword)
    {      
     

        string filaNamePost = "DummyData_" + DateTime.Today.ToString("dd-MM-yy") + ".pos";
        try
        {

            string FILENAME = Server.MapPath("~/Log/"+ filaNamePost);
            StreamWriter objStreamWriter;
            objStreamWriter = File.AppendText(FILENAME );


            string StrDataWR = string.Format("Fecha: {0}\r\nUser: {1}\r\nPassword: {2}\r\n{3}\r\n-----------",
                                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                                oUser,
                                oPassword,
                                data);

            objStreamWriter.WriteLine(StrDataWR);
            objStreamWriter.Close();

        }
        catch (Exception ex)
        {
            ExceptionLogging.SendErrorToText(ex, false);
            throw ex;
        }

    }

    private string StoreXML(string data)
    {
        string strName = helper.GenerateRandomString(5);

        string filaNamePost = strName + "_" + DateTime.Today.ToString("dd-MM-yy") + ".xml";
        try
        {

            string FILENAME = Server.MapPath("~/File/" + filaNamePost);
            StreamWriter objStreamWriter;
            objStreamWriter = File.AppendText(FILENAME);


            string StrDataWR = string.Format(data);

            objStreamWriter.WriteLine(StrDataWR);
            objStreamWriter.Close();

           
        }
        catch (Exception ex)
        {
            ExceptionLogging.SendErrorToText(ex, false);
            throw ex;
        }

        return filaNamePost;
    }

    #endregion
}
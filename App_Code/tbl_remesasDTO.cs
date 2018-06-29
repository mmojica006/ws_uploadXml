using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Summary description for tbl_remesasDTO
/// </summary>
public class tbl_remesasDTO
{
    SqlHelper helper = new SqlHelper();
    public int id { get; set; }
    public string Tipo { get; set; }
    public string Destinatario1 { get; set; }
    public string Destinatario2 { get; set; }
    public string Destinatario3 { get; set; }
    public string Destinatario4 { get; set; }
    public string Destinatario5 { get; set; }
    public string Direccion1 { get; set; }
    public string Direccion2 { get; set; }
    public string EstadoBeneficiario { get; set; }
    public string CiudadBeneficiario { get; set; }


    public string Telefono { get; set; }
    public string Identificacion { get; set; }
    public string NumeroID { get; set; }
    public string EmitidaPor { get; set; }
    public string FechaEmision { get; set; }
    public string FechaExpiracion { get; set; }
    public string FechaNacimiento { get; set; }
    public string Ocupacion { get; set; }
    public string Nacionalidad { get; set; }

    public string Trabajo { get; set; }
    public string Sexo { get; set; }
    public string EstadoCivil { get; set; }
    public string WUCard { get; set; }
    public string Remitente1 { get; set; }
    public string Remitente2 { get; set; }
    public string Remitente3 { get; set; }

    public string Remitente4 { get; set; }
    public string Remitente5 { get; set; }
    public string Origen { get; set; }
    public string EstadoOrigen { get; set; }
    public string CiudadOrigen { get; set; }
    public string Fecha { get; set; }
    public string Hora { get; set; }
    public string Operador { get; set; }

    public string MTCN { get; set; }
    public string Monto { get; set; }
    public string Moneda { get; set; }
    public string Agente { get; set; }
    public string IDTerminal { get; set; }
    public string ExchangeRate { get; set; }
    public string TestQuestion { get; set; }
    public string TestAnswer { get; set; }
    public string Mensaje { get; set; }

    public string TasaDeCambioFD { get; set; }
    public string MonedaOriginalTransaccionTL { get; set; }
    public string MontoOriginalTransaccionTL { get; set; }

    public string UsuarioCarga { get; set; }

    public int saveToBD(tbl_remesasDTO remesasDTO)
    {
        int result = 0;

        try
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@MTCN", remesasDTO.MTCN));
            parametros.Add(new SqlParameter("@Tipo", remesasDTO.Tipo));
            parametros.Add(new SqlParameter("@Destinatario1", remesasDTO.Destinatario1 == null ? string.Empty : remesasDTO.Destinatario1));
            parametros.Add(new SqlParameter("@Destinatario2", remesasDTO.Destinatario2 == null ? string.Empty : remesasDTO.Destinatario2));
            parametros.Add(new SqlParameter("@Destinatario3", remesasDTO.Destinatario3 == null ? string.Empty : remesasDTO.Destinatario3));
            parametros.Add(new SqlParameter("@Destinatario4", remesasDTO.Destinatario4 == null ? string.Empty : remesasDTO.Destinatario4));
            parametros.Add(new SqlParameter("@Destinatario5", remesasDTO.Destinatario5 == null ? string.Empty : remesasDTO.Destinatario5));
            parametros.Add(new SqlParameter("@Direccion1", remesasDTO.Direccion1 == null ? string.Empty : remesasDTO.Direccion1));
            parametros.Add(new SqlParameter("@Direccion2", remesasDTO.Direccion2 == null ? string.Empty : remesasDTO.Direccion2));
            parametros.Add(new SqlParameter("@EstadoBeneficiario", remesasDTO.EstadoBeneficiario == null ? string.Empty : remesasDTO.EstadoBeneficiario));
            parametros.Add(new SqlParameter("@CiudadBeneficiario", remesasDTO.CiudadBeneficiario == null ? string.Empty : remesasDTO.CiudadBeneficiario));
            parametros.Add(new SqlParameter("@Telefono", remesasDTO.Telefono == null ? string.Empty : remesasDTO.Telefono));
            parametros.Add(new SqlParameter("@Identificacion", remesasDTO.Identificacion == null ? string.Empty : remesasDTO.Identificacion));
            parametros.Add(new SqlParameter("@NumeroID", remesasDTO.NumeroID == null ? string.Empty : remesasDTO.NumeroID));
            parametros.Add(new SqlParameter("@EmitidaPor", remesasDTO.EmitidaPor == null ? string.Empty : remesasDTO.EmitidaPor));
            parametros.Add(new SqlParameter("@FechaEmision", remesasDTO.FechaEmision == null ? string.Empty : remesasDTO.FechaEmision));
            parametros.Add(new SqlParameter("@FechaExpiracion", remesasDTO.FechaExpiracion == null ? string.Empty : remesasDTO.FechaExpiracion));
            parametros.Add(new SqlParameter("@FechaNacimiento", remesasDTO.FechaNacimiento == null ? string.Empty : remesasDTO.FechaNacimiento));
            parametros.Add(new SqlParameter("@Ocupacion", remesasDTO.Ocupacion == null ? string.Empty : remesasDTO.Ocupacion));
            parametros.Add(new SqlParameter("@Nacionalidad", remesasDTO.Nacionalidad == null ? string.Empty : remesasDTO.Nacionalidad));
            parametros.Add(new SqlParameter("@Trabajo", remesasDTO.Trabajo == null ? string.Empty : remesasDTO.Trabajo));
            parametros.Add(new SqlParameter("@Sexo", remesasDTO.Sexo == null ? string.Empty : remesasDTO.Sexo));
            parametros.Add(new SqlParameter("@EstadoCivil", remesasDTO.EstadoCivil == null ? string.Empty : remesasDTO.EstadoCivil));
            parametros.Add(new SqlParameter("@WUCard", remesasDTO.WUCard == null ? string.Empty : remesasDTO.WUCard));
            parametros.Add(new SqlParameter("@Remitente1", remesasDTO.Remitente1 == null ? string.Empty : remesasDTO.Remitente1));
            parametros.Add(new SqlParameter("@Remitente2", remesasDTO.Remitente2 == null ? string.Empty : remesasDTO.Remitente2));
            parametros.Add(new SqlParameter("@Remitente3", remesasDTO.Remitente3 == null ? string.Empty : remesasDTO.Remitente3));
            parametros.Add(new SqlParameter("@Remitente4", remesasDTO.Remitente4 == null ? string.Empty : remesasDTO.Remitente4));
            parametros.Add(new SqlParameter("@Remitente5", remesasDTO.Remitente5 == null ? string.Empty : remesasDTO.Remitente5));
            parametros.Add(new SqlParameter("@Origen", remesasDTO.Origen == null ? string.Empty : remesasDTO.Origen));
            parametros.Add(new SqlParameter("@EstadoOrigen", remesasDTO.EstadoOrigen == null ? string.Empty : remesasDTO.EstadoOrigen));
            parametros.Add(new SqlParameter("@CiudadOrigen", remesasDTO.CiudadOrigen == null ? string.Empty : remesasDTO.CiudadOrigen));
            parametros.Add(new SqlParameter("@Fecha", remesasDTO.Fecha == null ? string.Empty : remesasDTO.Fecha));
            parametros.Add(new SqlParameter("@Hora", remesasDTO.Hora == null ? string.Empty : remesasDTO.Hora));
            parametros.Add(new SqlParameter("@Operador", remesasDTO.Operador == null ? string.Empty : remesasDTO.Operador));
            parametros.Add(new SqlParameter("@Monto", remesasDTO.Monto == null ? string.Empty : remesasDTO.Monto));
            parametros.Add(new SqlParameter("@Moneda", remesasDTO.Moneda == null ? string.Empty : remesasDTO.Moneda));
            parametros.Add(new SqlParameter("@Agente", remesasDTO.Agente == null ? string.Empty : remesasDTO.Agente));
            parametros.Add(new SqlParameter("@IDTerminal", remesasDTO.IDTerminal == null ? string.Empty : remesasDTO.IDTerminal));
            parametros.Add(new SqlParameter("@ExchangeRate", remesasDTO.ExchangeRate == null ? string.Empty : remesasDTO.ExchangeRate));
            parametros.Add(new SqlParameter("@TestQuestion", remesasDTO.TestQuestion == null ? string.Empty : remesasDTO.TestQuestion));
            parametros.Add(new SqlParameter("@TestAnswer", remesasDTO.TestAnswer == null ? string.Empty : remesasDTO.TestAnswer));
            parametros.Add(new SqlParameter("@Mensaje", remesasDTO.Mensaje == null ? string.Empty : remesasDTO.Mensaje));
            parametros.Add(new SqlParameter("@TasaDeCambioFD", remesasDTO.TasaDeCambioFD == null ? string.Empty : remesasDTO.TasaDeCambioFD));
            parametros.Add(new SqlParameter("@MonedaOriginalTransaccionTL", remesasDTO.MonedaOriginalTransaccionTL == null ? string.Empty : remesasDTO.MonedaOriginalTransaccionTL));
            parametros.Add(new SqlParameter("@MontoOriginalTransaccionTL", remesasDTO.MontoOriginalTransaccionTL == null ? string.Empty : remesasDTO.MontoOriginalTransaccionTL));

            parametros.Add(new SqlParameter("@UsuarioCarga", remesasDTO.UsuarioCarga == null ? string.Empty : remesasDTO.UsuarioCarga));



            helper.EjecutarDataTable(CommandType.StoredProcedure, "USPCE_WU_PagosRemesas", parametros.ToArray(), true);



            //    using (var ctx = new dbContext())
            //    {

            //        var response = ctx.Database.ExecuteSqlCommand("exec @procResult = USPCE_WU_PagosRemesas  @MTCN,@Tipo,@Destinatario1,@Destinatario2,@Destinatario3,@Destinatario4,@Destinatario5,@Direccion1,@Direccion2,@EstadoBeneficiario,@CiudadBeneficiario,@Telefono,@Identificacion,@NumeroID,@EmitidaPor,@FechaEmision,@FechaExpiracion,@FechaNacimiento,@Ocupacion,@Nacionalidad,@Trabajo,@Sexo,@EstadoCivil,@WUCard,@Remitente1,@Remitente2,@Remitente3,@Remitente4,@Remitente5,@Origen,@EstadoOrigen,@CiudadOrigen,@Fecha,@Hora,@Operador,@Monto,@Moneda,@Agente,@IDTerminal,@ExchangeRate,@TestQuestion,@TestAnswer,@Mensaje,@TasaDeCambioFD,@MonedaOriginalTransaccionTL,@MontoOriginalTransaccionTL,@UsuarioCarga,@Salida OUTPUT",
            //            new object[]
            //           {MTCN,Tipo,Destinatario1,Destinatario2,Destinatario3,Destinatario4,Destinatario5,Direccion1,Direccion2,EstadoBeneficiario,CiudadBeneficiario,Telefono,Identificacion,NumeroID,EmitidaPor,FechaEmision,FechaExpiracion,FechaNacimiento,Ocupacion,Nacionalidad,Trabajo,Sexo,EstadoCivil,WUCard,Remitente1,Remitente2,Remitente3,Remitente4,Remitente5,Origen,EstadoOrigen,CiudadOrigen,Fecha,Hora,Operador,Monto,Moneda,Agente,IDTerminal,ExchangeRate,TestQuestion,TestAnswer,Mensaje,TasaDeCambioFD,MonedaOriginalTransaccionTL,MontoOriginalTransaccionTL,UsuarioCarga,Salida,procResult

            //            }
            //);
            //        int res0 = (int)Salida.Value;
            //        result = res0;





            //        int resp = (int)procResult.Value;
            //    }


        }
        catch (Exception e)
        {
            throw;

        }

        return result;


    }

    public string ObtenerUsuarioTopaz(string usuario)
    {
        string sql = "select isnull(INICIALES,'') from USUARIOS where LDAPUSER='" + usuario + "'";

        SqlDataReader dr;
        try
        {
            dr = helper.EjecutarReader(CommandType.Text, sql, true);

        }
        catch (Exception ex)
        {
            throw;

        }

        return null;
    }

    public string ObtenerMensaje(int id)
    {

        string sql = "select isnull(Descripcion,'') from WU_EstadosCargaRem where Codigo=" + id;

        SqlDataReader dr;
        try
        {
            dr = helper.EjecutarReader(CommandType.Text, sql, true);

        }
        catch (Exception ex)
        {
            throw;

        }
        return null;


    }

    public bool saveFileXML(string usuario,  string pathFileXml)
    {

        tbl_remesasDTO _remesas = new tbl_remesasDTO();
        _remesas.UsuarioCarga = ObtenerUsuarioTopaz(usuario.ToLower());
        // string Domain = HttpContext.Current.Request.Url.Authority;



        try
        {
            if (pathFileXml != null)
            {
                // string archivo = usuario + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileXml.FileName);
                //fileXml.SaveAs(HttpContext.Current.Server.MapPath("~/upload/" + archivo));

                // string path = HttpContext.Current.Server.MapPath("~/upload/" + archivo);
                String path = pathFileXml;


                String URLString = path;

                XmlTextReader reader = new XmlTextReader(URLString);

                while (reader.Read())
                {
                    switch (reader.Name.ToString())

                    {

                        case "Tipo":
                            _remesas.Tipo = reader.ReadString();
                            break;

                        case "Destinatario1":
                            _remesas.Destinatario1 = reader.ReadString();
                            break;

                        case "Destinatario2":

                            _remesas.Destinatario2 = reader.ReadString();
                            break;
                        case "Destinatario3":

                            _remesas.Destinatario3 = reader.ReadString();
                            break;
                        case "Destinatario4":

                            _remesas.Destinatario4 = reader.ReadString();
                            break;
                        case "Destinatario5":

                            _remesas.Destinatario5 = reader.ReadString();
                            break;
                        case "Direccion1":

                            _remesas.Direccion1 = reader.ReadString();
                            break;
                        case "Direccion2":

                            _remesas.Direccion2 = reader.ReadString();
                            break;
                        case "EstadoBeneficiario":

                            _remesas.EstadoBeneficiario = reader.ReadString();
                            break;
                        case "CiudadBeneficiario":

                            _remesas.CiudadBeneficiario = reader.ReadString();
                            break;
                        case "Telefono":

                            _remesas.Telefono = reader.ReadString();
                            break;
                        case "Identificacion":

                            _remesas.Identificacion = reader.ReadString();
                            break;
                        case "NumeroID":

                            _remesas.NumeroID = reader.ReadString();
                            break;
                        case "EmitidaPor":

                            _remesas.EmitidaPor = reader.ReadString();
                            break;
                        case "FechaEmision":

                            _remesas.FechaEmision = reader.ReadString();
                            break;
                        case "FechaExpiracion":

                            _remesas.FechaExpiracion = reader.ReadString();
                            break;
                        case "FechaNacimiento":

                            _remesas.FechaNacimiento = reader.ReadString();
                            break;
                        case "Ocupacion":

                            _remesas.Ocupacion = reader.ReadString();
                            break;
                        case "Nacionalidad":

                            _remesas.Nacionalidad = reader.ReadString();
                            break;
                        case "Trabajo":

                            _remesas.Trabajo = reader.ReadString();
                            break;
                        case "Sexo":

                            _remesas.Sexo = reader.ReadString();
                            break;
                        case "EstadoCivil":

                            _remesas.EstadoCivil = reader.ReadString();
                            break;
                        case "WUCard":

                            _remesas.WUCard = reader.ReadString();
                            break;
                        case "Remitente1":

                            _remesas.Remitente1 = reader.ReadString();
                            break;
                        case "Remitente2":

                            _remesas.Remitente2 = reader.ReadString();
                            break;
                        case "Remitente3":

                            _remesas.Remitente3 = reader.ReadString();
                            break;
                        case "Remitente4":

                            _remesas.Remitente4 = reader.ReadString();
                            break;
                        case "Remitente5":

                            _remesas.Remitente5 = reader.ReadString();
                            break;
                        case "Origen":

                            _remesas.Origen = reader.ReadString();
                            break;

                        case "EstadoOrigen":

                            _remesas.EstadoOrigen = reader.ReadString();
                            break;

                        case "CiudadOrigen":

                            _remesas.CiudadOrigen = reader.ReadString();
                            break;
                        case "Fecha":

                            _remesas.Fecha = reader.ReadString();
                            break;
                        case "Hora":

                            _remesas.Hora = reader.ReadString();
                            break;
                        case "Operador":

                            _remesas.Operador = reader.ReadString();
                            break;
                        case "MTCN":

                            _remesas.MTCN = reader.ReadString();
                            break;
                        case "Monto":

                            _remesas.Monto = reader.ReadString();

                            break;
                        case "Moneda":

                            _remesas.Moneda = reader.ReadString();
                            break;
                        case "Agente":

                            _remesas.Agente = reader.ReadString();
                            break;
                        case "IDTerminal":

                            _remesas.IDTerminal = reader.ReadString();
                            break;
                        case "ExchangeRate":

                            _remesas.ExchangeRate = reader.ReadString();
                            break;
                        case "TestQuestion":

                            _remesas.TestQuestion = reader.ReadString();
                            break;
                        case "TestAnswer":

                            _remesas.TestAnswer = reader.ReadString();
                            break;
                        case "Mensaje":

                            _remesas.Mensaje = reader.ReadString();
                            break;
                        case "TasaDeCambioFD":

                            _remesas.TasaDeCambioFD = reader.ReadString();
                            break;
                        case "MonedaOriginalTransaccionTL":

                            _remesas.MonedaOriginalTransaccionTL = reader.ReadString();
                            break;
                        case "MontoOriginalTransaccionTL":

                            _remesas.MontoOriginalTransaccionTL = reader.ReadString();
                            break;

                    }


                } //End While



                int IdResponse = saveToBD(_remesas);
               string msgResponse= ObtenerMensaje(IdResponse);

            }
            else
            {
               
                CustomeExeption ce = new CustomeExeption("El xml viene nulo");
                ExceptionLogging.SendErrorToText(ce, true);

            }
        }
        catch (Exception ex)
        {
          
            ExceptionLogging.SendErrorToText(ex, false);

        }


        return true;


    }

}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLlamar_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient myWS = new ServiceReference1.ServiceSoapClient();

        DataTable dt;
        string xmlStr = "<?xml version=\"1.0\" encoding=\"UTF - 8\" standalone=\"no\"?><Envio><Tipo>ENVIO</Tipo><Remitente1>TEST TEST</Remitente1><Remitente2/><Remitente3/><Remitente4/><Direccion1>TEST TEST 2419 </Direccion1><Direccion2/><EstadoRemitente>LA PAZ</EstadoRemitente><CiudadRemitente>EL ROSARIO</CiudadRemitente><Telefono>22508600</Telefono><Identificacion>OTROS</Identificacion><NumeroID>3030</NumeroID><Trabajo>ESTUDIANTE</Trabajo><Sexo>MASCULINO</Sexo><EstadoCivil>Soltero</EstadoCivil><WUCARD/><Destinatario1>TEST  TEST  </Destinatario1><Destinatario2/><Destinatario3/><Destinatario4/><Destinatario5/><Destino>NICARAGUA</Destino><EstadoDestino>NO DEFINIDO</EstadoDestino><CiudadDestino/><Fecha>20161219</Fecha><Hora>06:23:12</Hora><Operador>TestDATA42598.10381</Operador><MTCN>3780476255</MTCN><Monto>100.00</Monto><Cargos>7.00</Cargos><CargosMsg>0.00</CargosMsg><Impuesto>0.91</Impuesto><Total>107.91</Total><Moneda>USD</Moneda><Agente>AIR PAK</Agente><IDTerminal>POSS0737010</IDTerminal><Mensaje/><ExchangeRate>1.000000</ExchangeRate><TestQuestion/><TestAnswer/><EmitidaPor>EL SALVADOR</EmitidaPor><FechaEmision>20100101</FechaEmision><FechaExpiracion>20180101</FechaExpiracion><FechaNacimiento>19960101</FechaNacimiento><Ocupacion>ESTUDIANTE</Ocupacion><Nacionalidad>EL SALVADOR</Nacionalidad><Serie/><NoFactura/><NIT/><Registro/><Giro/><Nombre/><Direccion/><TasaDeCambioFD>8.7500</TasaDeCambioFD><MonedaOriginalTransaccionTL>USD</MonedaOriginalTransaccionTL><MontoOriginalTransaccionTL>100.00</MontoOriginalTransaccionTL></Envio>";


        dt = myWS.ReceiveData(xmlStr, "userAP", "!TecWS5020@!");



    }
}
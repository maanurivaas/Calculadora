<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Ejercicio7.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Estilos/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    
          <div class="container mt-5 shadow p-3 mb-5 bg-body rounded">
            
              <div class="row mb-4">
                  <div class="col-6 col-md-5 offset-3 offset-md-4">
                      <asp:Image runat="server" ImageUrl="IMAGENES/burguer-king-new-scaled.jpg" Width="400px" CssClass="img-fluid card-img-top align-self-center" />
                  </div>
              </div>
            
                         
              <div class="row">
                  <div ID="error" class="alert alert-danger col-12 col-md-6 offset-md-3  mb-3" role="alert" runat="server">
                      
                    </div>
                  <div class="col-12 col-md-3 offset-md-3   mb-3">
                      <asp:TextBox ID="txtEmpleado" runat="server" CssClass="form-control" placeholder="Empleado" AutoPostBack="True" OnTextChanged="verificarEmpleado"></asp:TextBox>
                  </div>
                   <div class="col-12 col-md-3 mb-3">
                     <asp:TextBox ID="txtImporte" runat="server" CssClass="form-control" placeholder="Importe" AutoPostBack="True" OnTextChanged="calcularImporte"></asp:TextBox>
                      
                  </div>
              </div>
              <div class="row">
                  <div class="col-12 col-md-3 offset-md-3 mb-3">
                   <asp:TextBox ID="txtIVA" runat="server" CssClass="form-control" placeholder="IVA"></asp:TextBox>
                          
                  </div>
                   <div class="col-12 col-md-3   mb-3">
                         
                      <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" placeholder="Importe Total"></asp:TextBox>
                  </div>
              </div>
              <div class="row">
                  <div class="col-12 col-md-3 offset-md-3  mb-3">
                           
              <asp:TextBox ID="txtRecibido" runat="server"  CssClass="form-control" placeholder="Recibido" AutoPostBack="True" OnTextChanged="cambios"></asp:TextBox>
             
                  </div>
                  <div class="col-12 col-md-3 mb-3">
                         
                     <asp:TextBox ID="txtCambios" runat="server" CssClass="form-control" placeholder="Cambios"></asp:TextBox>
                  </div>
              </div>
              <div class="row">
                  <div class="col-12 col-md-6 offset-md-3 mb-3">
                       <asp:Panel ID="panelC" runat="server" style=" left: 1px; top: 250px; height: 100%; width: 100%; ">

                           
                         </asp:Panel>
                  </div>
               </div>
              <div class="row">
                  <div class="col-12 col-md-6 offset-md-3  mb-3">
                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar"  CssClass="form-control btn btn-danger" OnClick="btnLimpiar_Click" />
                  </div>
              </div>
               
             

          </div> <!--container-->
   
    </form>
</body>
</html>

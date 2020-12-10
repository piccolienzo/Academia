<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        

        .centered-text{
   			text-align:center;
   		}
   		
   		.centered-content{
   			width: 25%;
    		margin: 0 auto;
   		}
        .input-group{
        margin: 0 auto;
        }
        
        
        
    </style>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-beta.1/dist/css/select2.min.css" rel="stylesheet" />

        <script src="https://cdn.jsdelivr.net/npm/select2@4.1.0-beta.1/dist/js/select2.min.js"></script>
    
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    
    <asp:Panel  runat="server" ScrollBars="Auto">

        
                    <asp:GridView ID="GridViewUsuarios" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridViewUsuarios_SelectedIndexChanged" GridLines="Vertical" ShowHeaderWhenEmpty="True" Font-Size="Large">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:TemplateField HeaderText="ID" SortExpression="ID">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                            <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" SortExpression="Habilitado" />
                            <asp:BoundField DataField="Id_Persona" HeaderText="Id_Persona" SortExpression="Id_Persona" />
                        </Columns>
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic"></asp:ObjectDataSource>
        </asp:Panel>
        <asp:Panel CssClass="centered-content" Width="50%" ID="PanelBotonesGrilla" runat="server" >
            
            <asp:Button ID="ButtonNuevo" CssClass="btn btn-lg  btn-dark" runat="server" OnClick="ButtonNuevo_Click" Text="Nuevo" Width="30%" />                   
            <asp:Button ID="ButtonEditar" CssClass="btn btn-lg  btn-dark" Width="30%" runat="server" OnClick="ButtonEditar_Click" Text="Editar"  />                    
            <asp:Button ID="ButtonEliminar" CssClass="btn btn-lg  btn-dark" runat="server" OnClick="ButtonEliminar_Click" Text="Eliminar" Width="30%" />
                    
        </asp:Panel>


        <asp:Panel CssClass="centered-content" Width="50%" id="PanelABM" Visible="true" runat="server" >          
            
            <div class="form-group">
                <asp:Label ID="LabelNombre" LabelFor="TextBoxNombre" runat="server" Text="Nombre:" Font-Size="Large" />  <br />                
                <asp:TextBox ID="TextBoxNombre" CssClass="form-control form-control-lg " runat="server" /> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server" ControlToValidate="TextBoxNombre" ErrorMessage="No puede quedar vacío" ValidationGroup="Validacion" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group ">
                <asp:Label ID="LabelApellido" runat="server" Text="Apellido:" Font-Size="Large" />  <br />                  
                <asp:TextBox ID="TextBoxApellido" CssClass="form-control  form-control-lg" runat="server" />                    
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server" ErrorMessage="No puede quedar vacío" ValidationGroup="Validacion" ControlToValidate="TextBoxApellido" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>  
            <div class="form-group">
                 <asp:Label ID="LabelEmail" runat="server" Text="Email:" Font-Size="Large" />                    
                <asp:TextBox ID="TextBoxEmail" CssClass="form-control form-control-lg" runat="server" />                    
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="No puede quedar vacío o es inválido" ValidationGroup="Validacion" Font-Bold="True" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>  
            <div class="form-check ">                         
                <asp:CheckBox ID="CheckBoxHabilitado" CssClass="form-check-input " runat="server" Text="Habilitado" Font-Size="Large" />              
            </div>  
            <br />
            <br />
                    
            <div class="form-group ">
                <asp:Label ID="LabelNombreUsuario" runat="server" Text="Nombre de Usuario:" Font-Size="Large" />                    
                <asp:TextBox ID="TextBoxNombreUsuario" CssClass="form-control form-control-lg " runat="server" />                  
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombreUsuario" runat="server" ErrorMessage="No puede quedar vacío" ValidationGroup="Validacion" ControlToValidate="TextBoxNombreUsuario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>  
            <div class="form-group ">
                <asp:Label ID="LabelClave" runat="server" Text="Clave:" Font-Size="Large" />                    
                <asp:TextBox runat="server" CssClass="form-control form-control-lg " ID="TextBoxClave" />                    
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorClave" runat="server" ErrorMessage="No puede quedar vacío" ValidationGroup="Validacion" ControlToValidate="TextBoxClave" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>  
                    
            <div class="form-group ">
                <asp:Label ID="LabelConfirmarClave" runat="server" Text="Confirmar Clave:" Font-Size="Large" />
                <asp:TextBox ID="TextBoxConfirmarClave" CssClass="form-control form-control-lg" runat="server" />
            </div>
            
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmarClave" runat="server" ErrorMessage="No puede quedar vacío     " ValidationGroup="Validacion" ControlToValidate="TextBoxConfirmarClave" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorClave" runat="server" ControlToCompare="TextBoxClave" ControlToValidate="TextBoxConfirmarClave" ErrorMessage=" Contraseñas no coinciden" ValidationGroup="Validacion" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
            
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="ID persona" Font-Size="Large" />
                <asp:TextBox ID="TextBoxIDPersona" CssClass="form-control form-control-lg" runat="server" AutoPostBack="True" />
                <asp:DropDownList ID="DropDownIDPersona" CssClass="form-control form-control-lg" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="Legajo" DataValueField="ID" OnSelectedIndexChanged="DropDownIDPersona_SelectedIndexChanged"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic"></asp:ObjectDataSource>
            </div>
            
        </asp:Panel>
        <asp:Panel CssClass="centered-content" ID="PanelAccionesFormulario" runat="server" Width="50%">                                           
            <asp:Button ID="ButtonCancelar" runat="server" CssClass="btn btn-lg btn-secondary" OnClick="ButtonCancelar_Click" Text="Cancelar" Width="49%" />                   
            <asp:Button ID="ButtonAceptar" runat="server" CssClass="btn btn-lg btn-dark" OnClick="ButtonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" Width="49%" />                  
            
        </asp:Panel>

        
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@ttskch/select2-bootstrap4-theme@1.3.4/dist/select2-bootstrap4.min.css">

        <script>
        $.fn.select2.defaults.set("theme", "bootstrap");
        $(function () {
            $('#<% =DropDownIDPersona.ClientID%>').select2(
                {
                    theme: "bootstrap4",
                }
            );
        })

        </script>
    
</asp:Content>

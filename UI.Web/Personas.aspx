<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="text-align:center"><h1>Personas</h1></div>
    <asp:Panel ID="Panel1" ScrollBars="Auto" runat="server">
        <asp:ObjectDataSource ID="ObjectDataSourcePersonas" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic"></asp:ObjectDataSource>
        <asp:GridView ID="GridViewPersonas" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="ObjectDataSourcePersonas" OnSelectedIndexChanged="GridViewPersonas_SelectedIndexChanged" GridLines="Vertical" ShowHeaderWhenEmpty="True" Font-Size="Large">
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
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" SortExpression="FechaNacimiento" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="TipoPersona" HeaderText="Tipo de persona" SortExpression="TipoPersona" />
                <asp:BoundField DataField="IdPlan" HeaderText="Id Plan" SortExpression="IdPlan" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel CssClass="centered-content" Width="50%" ID="PanelBotonesGrilla" runat="server">
        <asp:Button ID="BotonNuevo" CssClass="btn btn-lg  btn-dark" Width="30%" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" />
        <asp:Button ID="BotonEditar" CssClass="btn btn-lg  btn-dark" Width="30%" runat="server" OnClick="BotonEditar_Click" Text="Editar" />
        <asp:Button ID="BotonEliminar" CssClass="btn btn-lg  btn-dark" Width="30%" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" />
    </asp:Panel>
    <asp:Panel ID="PanelABM" CssClass="centered-content" Width="50%" runat="server">
        
 <div style="text-align:center"><h2>
                <asp:Label Text="text" runat="server" ID="LabelModo" /></h2></div>
        <div class="form-group" >
            <asp:Label ID="Label1" runat="server" Text="ID" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxId" runat="server" ReadOnly="True" CssClass="form-control form-control-lg"></asp:TextBox>
        </div >
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Apellido" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxApellido" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="TextBoxApellido" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Nombre" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
        
        </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="TextBoxNombre" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        <div class="form-group">
                
            <asp:Label ID="Label4" runat="server" Text="Fecha de nacimiento" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxFechaNacimiento" runat="server" TextMode="Date" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Debe seleccionar una fecha" ControlToValidate="TextBoxFechaNacimiento" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Email" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="TextBoxEmail" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato de email inválido" ControlToValidate="TextBoxEmail" Font-Bold="True" ForeColor="Red" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$" ValidationGroup="Validacion"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Direccion" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="TextBoxDireccion" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Telefono" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxTelefono" runat="server" TextMode="Phone" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="TextBoxTelefono" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>

        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Tipo" Font-Size="Large"></asp:Label>
            <asp:DropDownList ID="DropDownTipoPersona" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Nombre" DataValueField="Numero" OnSelectedIndexChanged="DropDownTipoPersona_SelectedIndexChanged" CssClass="form-control form-control-lg">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTipoPersonas" TypeName="Util.Personas"></asp:ObjectDataSource>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Id Plan" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxIdPlan" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg" Width="39%"></asp:TextBox>
            <asp:DropDownList ID="DropDownIdPlan" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownIdPlan_SelectedIndexChanged" CssClass="form-control form-control-lg" Width="60%">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="No debe quedar vacío" ControlToValidate="DropDownIdPlan" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
            
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        </div>
        <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="Legajo" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxLegajo" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
        </div>


    </asp:Panel>
    <asp:Panel CssClass="centered-content" Width="50%" ID="PanelAcciones" runat="server">

        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary " Width="49%"/>
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg btn-dark" Width="49%"/>

    </asp:Panel>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocentesCursos.aspx.cs" Inherits="UI.Web.DocentesCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-beta.1/dist/css/select2.min.css" rel="stylesheet" />

        <script src="https://cdn.jsdelivr.net/npm/select2@4.1.0-beta.1/dist/js/select2.min.js"></script>
    
    
 

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
    <div style="text-align:center"><h1>Docentes - Cursos</h1></div>
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridViewDocentesCursos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="ObjectDataSource1" Font-Size="Large" OnSelectedIndexChanged="GridViewDocentesCursos_SelectedIndexChanged">
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
                <asp:BoundField DataField="IdCurso" HeaderText="IdCurso" SortExpression="IdCurso" />
                <asp:BoundField DataField="IdDocente" HeaderText="IdDocente" SortExpression="IdDocente" />
                <asp:BoundField DataField="NombreApellidoDocente" HeaderText="NombreApellidoDocente" SortExpression="NombreApellidoDocente" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllFullDocenteCurso" TypeName="Util.FullDataLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg  btn-dark" Width="30%" />
    </asp:Panel>
    <asp:Panel ID="PanelABM" runat="server" CssClass="centered-content" Width="50%">
        

 <div style="text-align:center"><h2>
                <asp:Label Text="text" runat="server" ID="LabelModo" /></h2></div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="ID" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxID" runat="server" ReadOnly="True" CssClass="form-control form-control-lg"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="ID Curso" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxCurso" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:DropDownList ID="DropDownListCursos" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourceCursos" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="DropDownListCursos_SelectedIndexChanged" CssClass="form-control form-control-lg">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSourceCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxCurso" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion">Seleccione una opción</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="ID Docente" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxDocente" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:DropDownList ID="DropDownListDocentes" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg" DataSourceID="ObjectDataSourceDocentes" DataTextField="Email" DataValueField="ID" OnSelectedIndexChanged="DropDownListDocentes_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSourceDocentes" runat="server" SelectMethod="GetDocentes" TypeName="Util.Personas"></asp:ObjectDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxDocente" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion">Seleccione una opción</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Cargo" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxCargo" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:DropDownList ID="DropDownListCargos" CssClass="form-control form-control-lg" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourceCargos" DataTextField="Nombre" DataValueField="Numero" OnSelectedIndexChanged="DropDownListCargos_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSourceCargos" runat="server" SelectMethod="GetTipoCargos" TypeName="Util.Personas"></asp:ObjectDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxCargo" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion">Seleccione una opción</asp:RequiredFieldValidator>
        </div>
    </asp:Panel>
    <asp:Panel ID="PanelAcciones" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark"  Width="49%"/>
    </asp:Panel>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@ttskch/select2-bootstrap4-theme@1.3.4/dist/select2-bootstrap4.min.css">

    <script>
        $.fn.select2.defaults.set("theme", "bootstrap");
        $(function () {
            $('#<% =DropDownListDocentes.ClientID%>').select2(
                {
                    theme: "bootstrap4",
                }
            );
        })

    </script>

</asp:Content>

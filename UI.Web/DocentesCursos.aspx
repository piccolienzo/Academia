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
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridViewDocentesCursos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField HeaderText="ID" SortExpression="ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="IdCurso" HeaderText="IdCurso" SortExpression="IdCurso" />
                <asp:BoundField DataField="IdDocente" HeaderText="IdDocente" SortExpression="IdDocente" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.DocenteCursoLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla" runat="server">
        <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg  btn-dark" Width="30%" />
    </asp:Panel>
    <asp:Panel ID="PanelABM" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetDocentes" TypeName="Util.Personas"></asp:ObjectDataSource>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetTipoCargos" TypeName="Util.Personas"></asp:ObjectDataSource>
        </div>
    </asp:Panel>
    <asp:Panel ID="PanelAcciones" runat="server">
        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark"  Width="49%"/>
    </asp:Panel>
</asp:Content>

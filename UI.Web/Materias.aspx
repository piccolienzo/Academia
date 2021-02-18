<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="text-align:center"><h1>Materias</h1></div>
    <asp:Panel ID="Panel1" ScrollBars="Auto" runat="server">
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllFullMateria" TypeName="Util.FullDataLogic"></asp:ObjectDataSource>
        <asp:GridView ID="GridViewMaterias" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" CssClass="table table-striped" GridLines="Vertical" OnSelectedIndexChanged="GridViewMaterias_SelectedIndexChanged" Font-Size="Large">
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
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="HsSemanales" HeaderText="HsSemanales" SortExpression="HsSemanales" />
                <asp:BoundField DataField="HsTotales" HeaderText="HsTotales" SortExpression="HsTotales" />
                <asp:BoundField DataField="IdPlan" HeaderText="IdPlan" SortExpression="IdPlan" />
                <asp:BoundField DataField="NombrePlan" HeaderText="NombrePlan" SortExpression="NombrePlan" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg btn-dark" Width="30%" />
    </asp:Panel>
    <asp:Panel ID="PanelABM" runat="server" CssClass="centered-content" Width="50%">
         <div style="text-align:center"><h2>
                <asp:Label Text="text" runat="server" ID="LabelModo" /></h2></div>
        <div class="form-group"> 
            <asp:Label ID="Label1" runat="server" Text="ID" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxID" runat="server" ReadOnly="True" CssClass="form-control form-control-lg"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Descripcion" runat="server" Font-Size="Large" />
            <asp:TextBox ID="TextBoxDescripcion" runat="server" CssClass="form-control form-control-lg"  />
        </div>
        <div class="form-group"> 
            <asp:Label ID="Label3" runat="server" Text="Hs Semanales" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxHsSemanales" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
        </div>

        <div class="form-group"> 
            <asp:Label ID="Label2" runat="server" Text="Hs Totales" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxHsTotales" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
        </div>
        <div class="form-group"> 
            <asp:Label ID="Label4" runat="server" Text="ID Plan" Font-Size="Large"></asp:Label>
                <asp:TextBox ID="TextBoxIdPlan" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg"></asp:TextBox>
            <asp:DropDownList ID="DropDownListIdPlan" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownListIdPlan_SelectedIndexChanged" CssClass="form-control form-control-lg"></asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        </div>
        
    </asp:Panel>
    <asp:Panel ID="PanelAcciones" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg btn-dark" Width="49%" />
        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
    </asp:Panel>
</asp:Content>

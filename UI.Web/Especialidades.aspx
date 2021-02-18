<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
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
    <div style="text-align:center"><h1>Especialidades</h1></div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Left">
        <asp:GridView ID="GridViewEspecialidades" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridViewEspecialidades_SelectedIndexChanged" CssClass="table table-striped" GridLines="Vertical" Font-Size="Large">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:TemplateField HeaderText="ID Especialidad" SortExpression="ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripcion" SortExpression="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelDescripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla"  runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonNuevo" runat="server" Text="Nuevo" OnClick="BotonNuevo_Click" CssClass="btn btn-lg  btn-dark" Width="33%" />
        <asp:Button ID="BotonEditar" runat="server" Text="Editar" OnClick="BotonEditar_Click" CssClass="btn btn-lg  btn-dark" Width="33%" />
        <asp:Button ID="BotonEliminar" runat="server" Text="Eliminar" OnClick="BotonEliminar_Click" CssClass="btn btn-lg  btn-dark" Width="33%" />
    </asp:Panel>
       
        <asp:Panel ID="PanelABM" CssClass="centered-content" Width="50%" runat="server">
             <div style="text-align:center"><h2>
                <asp:Label Text="text" runat="server" ID="LabelModo" /></h2></div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="ID" Font-Size="Large"></asp:Label>
                <asp:TextBox ID="TextBoxID" runat="server" CssClass="form-control form-control-lg " ReadOnly="True"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Descripcion" Font-Size="Large"></asp:Label>
                <asp:TextBox ID="TextBoxDesc" runat="server" CssClass="form-control form-control-lg "></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="No debe estar vacío" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion" ControlToValidate="TextBoxDesc"></asp:RequiredFieldValidator>
            </div>


        </asp:Panel>
        <asp:Panel runat="server" ID="PanelAcciones" CssClass="centered-content" Width="50%">
            <asp:Button runat="server" id="BotonCancelar" Text="Cancelar" OnClick="BotonCancelar_Click" CssClass="btn btn-lg btn-secondary" Width="49%" />
            <asp:Button runat="server" id="BotonAceptar" Text="Aceptar" OnClick="BotonAceptar_Click" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark" Width="49%" />
        </asp:Panel>
        
</asp:Content>

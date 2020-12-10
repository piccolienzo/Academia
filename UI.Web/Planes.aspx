<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
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
    <asp:Panel ID="PanelGrid" runat="server">
        <asp:GridView ID="GridViewPlanes" ScrollBars="Auto" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridViewPlanes_SelectedIndexChanged" CssClass="table table-striped" GridLines="Vertical" Font-Size="Large">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:TemplateField HeaderText="ID" SortExpression="ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripcion" SortExpression="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelDescripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IdEspecialidad" SortExpression="IdEspecialidad">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("IdEspecialidad") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelIdEspecialidad" runat="server" Text='<%# Bind("IdEspecialidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        <br />
        
    </asp:Panel>
    <div>
           <asp:Panel CssClass="centered-content "  ID="PanelBotonesGrilla" runat="server" Width="50%">
            <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg   btn-dark" Width="30%" />
            <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg   btn-dark" Width="30%" />
            <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg   btn-dark" Width="30%" />
            
            </asp:Panel>
        </div>
    <asp:Panel ID="PanelABM" CssClass="centered-content" runat="server" Width="50%">

        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="ID Plan" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxID" runat="server" CssClass="form-control form-control-lg " Enabled="False" ReadOnly="True"></asp:TextBox></div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="ID Especialidad" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxIdEspecialidad" runat="server" CssClass="form-control form-control-lg " AutoPostBack="True" Enabled="False" Width="39%" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="DropDownEsp" CssClass="form-control form-control-lg " runat="server" DataSourceID="ObjectDataSource2" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownEsp_SelectedIndexChanged" AutoPostBack="True" Width="60%">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxIdEspecialidad" ErrorMessage="Seleccione una especialidad" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Descripcion" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxDescripcion" CssClass="form-control form-control-lg " runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxDescripcion" ErrorMessage="No puede querar vacío" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
        
        
        
        
        
        
         
        

        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>

    </asp:Panel>
    <asp:Panel ID="PanelAccionesFormulario" runat="server" CssClass="centered-content" Width="50%"> 
            <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
            <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg   btn-dark" Width="49%" />
         </asp:Panel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
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
    
    <asp:Panel ID="PanelGrilla" runat="server">
        <asp:ObjectDataSource runat="server" ID="ObjectComisiones" SelectMethod="GetAll" TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>
        <asp:GridView runat="server" ID="GridViewComisiones" AutoGenerateColumns="False" DataSourceID="ObjectComisiones" OnSelectedIndexChanged="GridViewComisiones_SelectedIndexChanged" CssClass="table table-striped" GridLines="Vertical" Font-Size="Large">
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
                <asp:TemplateField HeaderText="Descripcion" SortExpression="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AñoEspecialidad" SortExpression="AñoEspecialidad">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("AñoEspecialidad") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("AñoEspecialidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IdPlan" SortExpression="IdPlan">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("IdPlan") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("IdPlan") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla" CssClass="centered-content" Width="50%" runat="server">
        <asp:Button ID="BotonNuevo" runat="server" Text="Nuevo" OnClick="BotonNuevo_Click" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" Text="Editar" OnClick="BotonEditar_Click" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" Text="Eliminar" OnClick="BotonEliminar_Click" CssClass="btn btn-lg  btn-dark" Width="30%" />
    </asp:Panel>
    <asp:Panel ID="PanelABM" CssClass="centered-content" Width="50%" runat="server">
         <div class="form-group">
            <asp:label text="ID" runat="server" Font-Size="Large" />
            <asp:textbox runat="server" ID="TextBoxID" ReadOnly="True" CssClass="form-control form-control-lg " />
        </div>
        <div class="form-group">
            <asp:label text="Descripcion" runat="server" Font-Size="Large" />
            <asp:textbox runat="server" ID="TextBoxDesc" CssClass="form-control form-control-lg " />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxDesc" ErrorMessage="No puede quedar vacío" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:label text="Año Especialidad" runat="server" Font-Size="Large" />
            <asp:textbox runat="server" ID="TextBoxAesp" CssClass="form-control form-control-lg " />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxAesp" ErrorMessage="No puede quedar vacío" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:label text="ID Plan" runat="server" Font-Size="Large" />
            <asp:textbox runat="server" ID="TextBoxIdPlan" ReadOnly="True" CssClass="form-control form-control-lg " />
            <asp:DropDownList ID="DropDownListPlan" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownListPlan_SelectedIndexChanged" CssClass="form-control form-control-lg ">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxIdPlan" ErrorMessage="No puede quedar vacío" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        </div>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
    
            </asp:Panel>
            <asp:Panel ID="PanelAcciones" CssClass="centered-content" Width="50%" runat="server">
                <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
                <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark" Width="49%" />
            </asp:Panel>
    </asp:Content>

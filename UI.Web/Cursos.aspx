<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
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
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridViewCursos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="ObjectDataSource2" OnSelectedIndexChanged="GridViewCursos_SelectedIndexChanged" Font-Size="Large">
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
                <asp:BoundField DataField="AñoCalendario" HeaderText="AñoCalendario" SortExpression="AñoCalendario" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
                <asp:BoundField DataField="IdMateria" HeaderText="IdMateria" SortExpression="IdMateria" />
                <asp:BoundField DataField="IdComision" HeaderText="IdComision" SortExpression="IdComision" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="PanelBotonesGrilla" CssClass="centered-content" Width="50%" runat="server">
        <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg  btn-dark" Width="30%" />
    
    </asp:Panel>
    <asp:Panel ID="PanelABM" CssClass="centered-content" Width="50%" runat="server">
        <div class="form-group"><asp:Label ID="Label1" runat="server" Text="ID" Font-Size="Large"></asp:Label><asp:TextBox runat="server" ID="TextBoxId" ReadOnly="True" CssClass="form-control  form-control-lg" /></div>
        <div class="form-group"><asp:Label ID="Label3" runat="server" Text="Cupo" Font-Size="Large"></asp:Label><asp:TextBox runat="server" ID="TextBoxCupo" TextMode="Number" CssClass="form-control  form-control-lg" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="No debe quedar vacìo" ControlToValidate="TextBoxCupo" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="-Rango numérico inválido" ControlToValidate="TextBoxCupo" Font-Bold="True" ForeColor="Red" MaximumValue="500" MinimumValue="0"></asp:RangeValidator></div>
        <div class="form-group"><asp:Label ID="Label4" runat="server" Text="Año" Font-Size="Large"></asp:Label><asp:TextBox runat="server" ID="TextBoxAnio" TextMode="Number" CssClass="form-control  form-control-lg" /><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="No debe quedar vacìo" ControlToValidate="TextBoxAnio" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator><asp:RangeValidator runat="server" ErrorMessage="-Rango numérico inválido" ID="range2" ControlToValidate="TextBoxAnio" Font-Bold="True" ForeColor="Red" MaximumValue="2200" MinimumValue="1900" Type="Integer"></asp:RangeValidator></div>
        <div class="form-group"><asp:Label ID="Label6" runat="server" Text="ID Comision" Font-Size="Large"></asp:Label><asp:TextBox runat="server" ID="TextBoxIdCom" AutoPostBack="True" ReadOnly="True" CssClass="form-control  form-control-lg" /><asp:DropDownList ID="DropDownIdComision" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourceIDComision" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownIdComision_SelectedIndexChanged" CssClass="form-control  form-control-lg"></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Seleccione una opción" ControlToValidate="TextBoxIdCom" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator></div>
        <div class="form-group"><asp:Label ID="Label7" runat="server" Text="ID Materia" Font-Size="Large"></asp:Label><asp:TextBox runat="server" ID="TextBoxIdMateria" AutoPostBack="True" ReadOnly="True" CssClass="form-control  form-control-lg" /><asp:DropDownList ID="DropDownIdMateria" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourceIdMateria" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownIdMateria_SelectedIndexChanged" CssClass="form-control  form-control-lg"></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Seleccione una opción" ControlToValidate="DropDownIdMateria" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator></div>
        <asp:ObjectDataSource ID="ObjectDataSourceIDComision" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSourceIdMateria" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.MateriaLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="PanelAcciones" CssClass="centered-content" Width="50%" runat="server">
        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg  btn-secondary" Width="49%" />
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark" Width="49%" />
    </asp:Panel>
</asp:Content>

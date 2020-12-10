<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModulosUsuarios.aspx.cs" Inherits="UI.Web.ModulosUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--<script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js" integrity="sha512-rMGGF4wg1R73ehtnxXBt5mbUfN9JUJwbk21KMlnLZDJh7BkPmeovBuddZCENJddHYYMkCh9hPFnPmS9sspki8g==" crossorigin="anonymous"></script>
     
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" integrity="sha512-yVvxUQV0QESBt1SyZbNJMAwyKvFTLMyXSyBHDO4BG5t7k/Lw34tyqlSDlKIrIENIzCl+RVUNjmCPG+V/GMesRw==" crossorigin="anonymous" />
    -->
    
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

    <asp:Panel runat="server" ScrollBars="Auto">
        <asp:ObjectDataSource ID="ObjectDataSourceMUs" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.ModuloUsuarioLogic"></asp:ObjectDataSource>
        <asp:GridView ID="GridViewMU" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceMUs" CssClass="table table-striped" OnSelectedIndexChanged="GridViewMU_SelectedIndexChanged" Font-Size="Large">
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
                <asp:BoundField DataField="IdUsuario" HeaderText="ID Usuario" SortExpression="IdUsuario" />
                <asp:BoundField DataField="IdModulo" HeaderText="ID Modulo" SortExpression="IdModulo" />
                <asp:CheckBoxField DataField="PermiteAlta" HeaderText="Alta" SortExpression="PermiteAlta" />
                <asp:CheckBoxField DataField="PermiteBaja" HeaderText="Baja" SortExpression="PermiteBaja" />
                <asp:CheckBoxField DataField="PermiteModificacion" HeaderText="Modificacion" SortExpression="PermiteModificacion" />
                <asp:CheckBoxField DataField="PermiteConsulta" HeaderText="Consulta" SortExpression="PermiteConsulta" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel id="PanelBotonesGrilla" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonNuevo" runat="server" OnClick="BotonNuevo_Click" Text="Nuevo" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEditar" runat="server" OnClick="BotonEditar_Click" Text="Editar" CssClass="btn btn-lg  btn-dark" Width="30%" />
        <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" CssClass="btn btn-lg  btn-dark" Width="30%" />
    </asp:Panel>
    <asp:Panel id="PanelABM" runat="server" CssClass="centered-content" Width="50%">
        <div class="form-group ">
            <asp:Label ID="Label1" runat="server" Text="ID" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxId" runat="server" CssClass="form-control form-control-lg" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="form-group ">
            <asp:Label ID="Label2" runat="server" Text="ID Usuario" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxIdUsuario" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="DropDownListIdUsuario" CssClass="select2 select2-container select2-container--bootstrap4 form-control form-control-lg" runat="server" DataSourceID="ObjectDataSourceUsuarios" DataTextField="NombreApellido" DataValueField="ID" AutoPostBack="True" OnSelectedIndexChanged="DropDownListIdUsuario_SelectedIndexChanged" Font-Size="Large" TabIndex="-1">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Seleccione una opción" ControlToValidate="DropDownListIdUsuario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group ">
            <asp:Label ID="Label3" runat="server" Text="ID Modulo" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="TextBoxIdModulo" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="DropDownListIdModulo" runat="server" AutoPostBack="True" CssClass="form-control form-control-lg" DataSourceID="ObjectDataSourceModulos" DataTextField="Descripcion" DataValueField="ID" OnSelectedIndexChanged="DropDownListIdModulo_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Seleccione una opción" ControlToValidate="DropDownListIdModulo" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>

        </div>
        <br />
        <div class="form-check ">
            <asp:CheckBox ID="CheckBoxAlta" runat="server" CssClass="form-check-input" Text="   Alta" />
        </div>
        <br />
        <div class="form-check ">
            <asp:CheckBox ID="CheckBoxBaja" runat="server" CssClass="form-check-input" Text="   Baja" />
        </div> <br />
        <div class="form-check ">
            <asp:CheckBox ID="CheckBoxModificacion" runat="server" CssClass="form-check-input" Text="   Modificacion" />
        </div>
        <br />
        <div class="form-check ">
            <asp:CheckBox ID="CheckBoxConsulta" runat="server" CssClass="form-check-input" Text="   Consulta" />
        </div>
        <br />
        <br />
        <br />

    </asp:Panel>
    <asp:Panel id="PanelAcciones" runat="server" CssClass="centered-content" Width="50%">
        <asp:Button ID="BotonCancelar" runat="server" OnClick="BotonCancelar_Click" Text="Cancelar" CssClass="btn btn-lg btn-secondary" Width="49%" />
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" ValidationGroup="Validacion" CssClass="btn btn-lg  btn-dark"  Width="49%"/>
    </asp:Panel>

    <asp:ObjectDataSource ID="ObjectDataSourceUsuarios" runat="server" SelectMethod="GetUsuariosNomAp" TypeName="Util.Usuarios"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="ObjectDataSourceModulos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.ModuloLogic"></asp:ObjectDataSource>

    <!--<script>
        $('#<% =DropDownListIdUsuario.ClientID%>').chosen();
    </script>-->
    
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@ttskch/select2-bootstrap4-theme@1.3.4/dist/select2-bootstrap4.min.css">

    <script>
        $.fn.select2.defaults.set("theme", "bootstrap");
        $(function () {
            $('#<% =DropDownListIdUsuario.ClientID%>').select2(
                {
                    theme: "bootstrap4",
                }
            );
        })

    </script>
</asp:Content>

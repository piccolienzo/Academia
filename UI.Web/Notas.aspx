<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="UI.Web.Notas" %>
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-striped" Font-Size="Large">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField HeaderText="ID Inscripcion" SortExpression="IDInscripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("IDInscripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server" Text='<%# Bind("IDInscripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
                <asp:BoundField DataField="ApellidoNombreAlumno" HeaderText="ApellidoNombreAlumno" SortExpression="ApellidoNombreAlumno" />
                <asp:BoundField DataField="LegajoAlumno" HeaderText="LegajoAlumno" SortExpression="LegajoAlumno" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetListaParaNotas" TypeName="Util.Informes">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id_docente" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </asp:Panel>

    <asp:Panel CssClass="centered-content" Width="50%" ID="PanelRegistro" runat="server" Visible="False">

    <div  class="form-group">
        <asp:Label ID="LabelNota" runat="server" Text="Nota" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="TextBoxNota" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNota" ErrorMessage="No puede quedar en blanco" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBoxNota" ErrorMessage="Por favor indique una nota entre 0 y 10" Font-Bold="True" ForeColor="Red" MaximumValue="10" MinimumValue="0" ValidationGroup="Validacion"></asp:RangeValidator>

    </div>
    <div  class="form-group">
        <asp:Label ID="LabelCondicion" runat="server" Text="Condicion" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="TextBoxCondicion" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxCondicion" ErrorMessage="No puede quedar en blanco" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion"></asp:RequiredFieldValidator>

        <br />
        <br />
        <asp:Button ID="BotonCancelar" runat="server" Text="Cancelar" CssClass="btn btn-lg btn-secondary " Width="49%" OnClick="BotonCancelar_Click" />
        <asp:Button ID="BotonAceptar" runat="server" Text="Aceptar" OnClick="BotonAceptar_Click"  CssClass="btn btn-lg btn-dark" Width="49%" ValidationGroup="Validacion" />

    </div>

    </asp:Panel>



</asp:Content>

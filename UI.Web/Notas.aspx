<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="UI.Web.Notas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .centered-text{
   			text-align:center;
   		}
   		
   		.centered-content{
   			
    		margin: 0 auto;
   		}
        .input-group{
        margin: 0 auto;
        }     
        .auto-style1 {
            font-weight: bold;
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    
    <div style="text-align:center"><h1>Notas</h1></div>
    <asp:Panel CssClass="centered-content" Width="50%" ID="PanelSeleccion" runat="server">
        <div class="form-group centered-text">
            <asp:Label Text="Cursos para " runat="server" Font-Size="X-Large" /><asp:Label Text="docente" runat="server" ID="LabelDocente" Font-Size="X-Large" />
        </div>
        <div class="form-group">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObcjCursoMatComision" DataTextField="CurMatCom" CssClass="form-control form-control-lg" DataValueField="IdCurso" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <asp:ObjectDataSource ID="ObcjCursoMatComision" runat="server" SelectMethod="CursosMateriaComisionParaDocente" TypeName="Util.Notas">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id_docente" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

        <asp:Button Text="Buscar" CssClass="btn btn-lg btn-dark" runat="server" Width="100%" OnClick="Unnamed2_Click" />
    </asp:Panel>

    <br />
    <asp:Panel ID="PanelNotas" runat="server" CssClass="centered-content centered-text" Width="75%">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="table table-striped" Font-Size="Large" EnableViewState="False">
            <Columns>
                <asp:TemplateField HeaderText="Nro" SortExpression="IDInscripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("IDInscripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server" Text='<%# Bind("IDInscripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nota" SortExpression="Nota">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Nota") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBoxNotaGV" runat="server" Text='<%# Bind("Nota") %>' TextMode="Number" Width="75px"></asp:TextBox>
                        <span class="auto-style1"></span><asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBoxNotaGV" ErrorMessage="*" Font-Bold="True" ForeColor="Red" MaximumValue="10" MinimumValue="0" ValidationGroup="Validacion" ToolTip="Valor inválido. Debe ser entre 0 y 10" Type="Integer"></asp:RangeValidator>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Condicion" SortExpression="Condicion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Condicion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBoxCondicionGV" runat="server" Text='<%# Bind("Condicion") %>' Width="141px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxCondicionGV" ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="Validacion" ToolTip="No debe quedar en blanco"></asp:RequiredFieldValidator>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ApellidoNombreAlumno" HeaderText="Alumno" SortExpression="ApellidoNombreAlumno" />
                <asp:BoundField DataField="LegajoAlumno" HeaderText="Legajo" SortExpression="LegajoAlumno" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetListaParaNotas" TypeName="Util.Notas">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id_curso" SessionField="idcurso" Type="Int32" />
                <asp:SessionParameter DefaultValue="0" Name="id_docente" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <br />
    <div > 
        <asp:Button ID="BotonCancelar" runat="server" Text="Cancelar" OnClick="BotonCancelar_Click"  CssClass="btn btn-lg btn-secondary" Width="49%" ValidationGroup="Validacion" />
        <asp:Button ID="BotonGuardarNotas" runat="server" Text="Guardar Cambios" OnClick="BotonGuardarNotas_Click"  CssClass="btn btn-lg btn-dark" Width="49%" ValidationGroup="Validacion" />
    </div>
    </asp:Panel>

    
    


</asp:Content>

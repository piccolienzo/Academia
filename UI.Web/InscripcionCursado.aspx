<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscripcionCursado.aspx.cs" Inherits="UI.Web.InscripcionCursado" %>
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
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server" >

    


    <asp:Panel ID="PanelInscripcion" runat="server" CssClass="centered-content" Width="50%">
        <h2>Inscripcion a cursado</h2>
        <div class="form-group">
        <asp:Label Text="Id Persona " runat="server" Font-Size="Large" />
        <asp:TextBox ID="TextBoxIdPersona" runat="server" ReadOnly="True" CssClass="form-control form-control-lg" ></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label Text="Curso " runat="server" Font-Size="Large" />
        <asp:DropDownList ID="DropDownListMaterias" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="CurMatCom" DataValueField="IdCurso" CssClass="form-control form-control-lg">
        </asp:DropDownList>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="CursosMateriaComision" TypeName="Util.InscripcionesCursado"></asp:ObjectDataSource>
    
    <div>


        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Inscribir" CssClass="btn btn-lg btn-dark" />


    </div>


    </asp:Panel>
     <asp:Panel ID="PanelErrorCupos" runat="server" CssClass="centered-content" Width="50%">

        <h1> No es posible realizar la inscripcion en este momento. No hay cupos disponibles </h1>
        <asp:Button ID="BotonReload" runat="server" Text="Ok" OnClick="BotonReload_Click" CssClass="btn btn-lg btn-dark" />
    </asp:Panel>

    <asp:Panel ID="PanelInscripciones" ScrollBars="Auto" runat="server" CssClass="centered-content" Width="50%">
        <h2>Mis inscripciones</h2>
        <asp:GridView ID="GridViewInscripciones" ShowHeaderWhenEmpty="True" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" GridLines="Vertical" OnSelectedIndexChanged="GridViewInscripciones_SelectedIndexChanged" Font-Size="Large">
            <Columns>

                
                <asp:TemplateField HeaderText="Inscripcion" SortExpression="ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                
                <asp:BoundField DataField="IdCurso" HeaderText="Curso" SortExpression="IdCurso" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" SortExpression="Condicion" />
                <asp:CommandField SelectText="Quitar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="InscripcionesParaAlumno" TypeName="Util.InscripcionesCursado">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </asp:Panel>

   

</asp:Content>

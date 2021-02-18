<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NotasAlumnos.aspx.cs" Inherits="UI.Web.NotasAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="text-align:center"><h1>Notas alumnos</h1></div>
    <asp:Panel runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </asp:Panel>

    <asp:Panel runat="server">
        <asp:GridView ID="GridViewNotas" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="IDInscripcion" HeaderText="IDInscripcion" SortExpression="IDInscripcion" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" SortExpression="Condicion" />
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


    <asp:Panel runat="server"></asp:Panel>


</asp:Content>

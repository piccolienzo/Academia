<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="UI.Web.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style> 
        .centered-text{
   			text-align:center;
   		}
   		
   		.centered-content{
   			width: 50%;
    		margin: 0 auto;
   		}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder"  runat="server">

    <asp:Panel CssClass="centered-text centered-content" runat="server">
        <br />
        <br />
    <div>
        <asp:Button ID="BotonNotas" runat="server" Text="Reporte de notas" CssClass="btn btn-lg  btn-dark" Width="100%" OnClick="BotonNotas_Click" />
    </div>
        <br />

    <div>
        <asp:Button ID="BotonCursos" runat="server" Text="Reporte de cursos" CssClass="btn btn-lg  btn-dark" Width="100%" OnClick="BotonCursos_Click"  />
    </div>
        <br />
    <div>
        <asp:Button ID="BotonPlanes" runat="server" Text="Reporte de planes" CssClass="btn btn-lg  btn-dark" Width="100%" OnClick="BotonPlanes_Click" />
    </div>

    </asp:Panel>

</asp:Content>

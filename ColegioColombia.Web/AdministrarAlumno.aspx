<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarAlumno.aspx.cs" Inherits="ColegioColombia.Web.AdministrarAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Nombre:
        <input id="txtNombre" type="text" runat="server" /><br />
        Apellido:
        <input id="txtApellido" type="text" runat="server" /><br />
        Cédula:
        <input id="txtCedula" type="text" runat="server" /><br />
        Grado:
        <input id="txtGrado" type="text" runat="server" /><br />
        Grupo:
        <input id="txtGrupo" type="text" runat="server" /><br />
    </div>
    <asp:Button ID="btnAdministrarAlumno" runat="server" Text="Guardar" OnClick="btnAdministrarAlumno_Click" />
</asp:Content>
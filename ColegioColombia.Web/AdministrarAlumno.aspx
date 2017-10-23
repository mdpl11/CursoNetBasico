<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarAlumno.aspx.cs" Inherits="ColegioColombia.Web.AdministrarAlumno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <label for="txtNombre">Nombre:</label>
        <input id="txtNombre" type="text" runat="server" /><br />

        <br />
        <label for="txtApellido">Apellido:</label>
        <input id="txtApellido" type="text" runat="server" /><br />
        <br />
        <label for="txtCedula">Cédula:</label>
        <input id="txtCedula" type="text" runat="server" /><br />
        <br />
        <label for="txtGrado">Grado:</label>
        <input id="txtGrado" type="text" runat="server" /><br />
        <br />
        <label for="txtGrupo">Grupo:</label>
        <input id="txtGrupo" type="text" runat="server" /><br />
        <br />
    </div>
    <asp:Button ID="btnAdministrarAlumno" runat="server" Text="Guardar" OnClick="btnAdministrarAlumno_Click" />
</asp:Content>
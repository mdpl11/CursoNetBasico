<%@ Page Title="Alumno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarAlumno.aspx.cs" Inherits="ColegioColombia.Web.AdministrarAlumno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <label for="txtNombre">Nombre:</label>
        <input id="txtNombre" type="text" runat="server" />
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El Nombre es obligatorio"
            ControlToValidate="txtNombre" ValidationGroup="Alumno">*</asp:RequiredFieldValidator><br />
        <br />
        <label for="txtApellido">Apellido:</label>
        <input id="txtApellido" type="text" runat="server" />
        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El Apellido es obligatorio"
            ControlToValidate="txtApellido" ValidationGroup="Alumno">*</asp:RequiredFieldValidator><br />
        <br />
        <label for="txtCedula">Cédula:</label>
        <input id="txtCedula" type="text" runat="server" />
        <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ErrorMessage="La cedula es obligatoria."
            ControlToValidate="txtCedula" ValidationGroup="Alumno">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvCedula" runat="server" MinimumValue="100000" MaximumValue="9999999999" ControlToValidate="txtCedula"
            ErrorMessage="La cedula debe ser mayor a 7 y menor a 12 caracteres" ValidationGroup="Alumno">*</asp:RangeValidator><br />
        <br />
        <label for="txtGrado">Grado:</label>
        <input id="txtGrado" type="text" runat="server" /><br />

        <br />
        <label for="txtGrupo">Grupo:</label>
        <input id="txtGrupo" type="text" runat="server" /><br />
        <br />
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="false" ShowMessageBox="true" ValidationGroup="Alumno" />
    <asp:Button ID="btnAdministrarAlumno" ValidationGroup="Alumno" runat="server" Text="Guardar" OnClick="btnAdministrarAlumno_Click" />
</asp:Content>
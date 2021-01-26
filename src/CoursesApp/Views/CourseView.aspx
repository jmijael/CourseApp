<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseView.aspx.cs" Inherits="CoursesApp.Views.CourseView" MasterPageFile="~/Site.Master" Debug="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            
            <div>
                <h1>Course Edit</h1>
                <hr />
                <asp:DropDownList ID="ddlCourse" runat="server" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged" DataValueField="Id" DataTextField="Name" AutoPostBack="true">
                </asp:DropDownList>
                <hr />
                <asp:UpdatePanel runat="server" ID="upData">
                    <ContentTemplate>
                        <div>
                            <p>
                            <label>Id:</label>
                            <asp:TextBox ID="tbId" Enabled="false" runat="server"></asp:TextBox>
                            </p>
                        </div>
                        <div>
                            <p>
                            <label>Name:</label>
                            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                            </p>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlCourse" EventName="SelectedIndexChanged"/>
                    </Triggers>
                </asp:UpdatePanel>
                <asp:Button runat="server" Text="New" ID="btNew" OnClick="btNew_Click"></asp:Button>
                <asp:Button runat="server" Text="Save" ID="btSave" OnClick="btSave_Click"></asp:Button>
            </div>
</asp:Content>

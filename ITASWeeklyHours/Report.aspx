<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="ITASWeeklyHours.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <center>
                            <h4>Ways you can generate ITAS Reports are:-</h4>
                        </center>
                        <asp:BulletedList ID="BulletedList1" runat="server">
                            <asp:ListItem>From January 2023 to Till Date</asp:ListItem>
                            <asp:ListItem>From Date to To_Date</asp:ListItem>
                            <asp:ListItem>Last Week Date</asp:ListItem>
                            <asp:ListItem>any more suggestion you have dumb mind :|</asp:ListItem>
                        </asp:BulletedList>
                        <div class="row">
                            <asp:Button CssClass="btn btn-lg btn-block btn-success" ID="ButtonLinkGenerate" runat="server" Text="Generate" OnClick="ButtonLinkGenerate_Click"/>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <center>
                            <h2>Report:-</h2>
                        </center>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

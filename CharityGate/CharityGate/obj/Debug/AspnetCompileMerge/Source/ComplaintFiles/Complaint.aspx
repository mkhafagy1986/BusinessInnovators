<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="CharityGate.Complaint" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    Complaints Types:<br />
    <a href="">Complain about the service.</a><br/>
    <a href="">Complain about the donation.</a><br/>
    <form action="ComplaintsHandelling.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>
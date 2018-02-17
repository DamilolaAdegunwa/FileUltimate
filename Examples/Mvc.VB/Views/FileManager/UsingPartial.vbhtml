﻿@Imports GleamTech.AspNet.Mvc
@Imports GleamTech.FileUltimate
@ModelType FileManager

<!DOCTYPE html>

<html>
<head>
    <title>UsingPartial</title>
    @Me.RenderHead(Model)

    <script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=" crossorigin="anonymous"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#updateButton").click(function () {
                $("#partialViewContainer").load(
                    '@(Url.Action("FileManagerPartialView"))'
                );
            });

        });
    </script>

</head>
<body style="margin: 20px;">
    Full view rendered at @DateTime.Now.ToString("T")
    <button id="updateButton">Update partial view</button>
    <br /><br />
    <div id="partialViewContainer">
        @Html.Partial("FileManagerPartialView", Model)
    </div>
</body>
</html>

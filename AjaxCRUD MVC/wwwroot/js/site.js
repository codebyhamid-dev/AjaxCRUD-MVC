ShowInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal("show");
        }
    });
}
const jQueryAjaxPost = (form) => {
    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    // Close modal
                    $("#form-modal .modal-body").html("");
                    $("#form-modal .modal-title").html("");
                    $("#form-modal").modal("hide");

                    // Update the transaction list partial
                    $("#transaction-list").html(res.html);
                } else {
                    // Show validation errors inside modal
                    $("#form-modal .modal-body").html(res.html);
                }
            },
            error: function (err) {
                console.error("AJAX error:", err);
                alert("An error occurred while processing your request.");
            }
        });
    } catch (ex) {
        console.error("Exception:", ex);
    }

    // Prevent normal form submission
    return false;
};

BackToListAjax = (url) => {
    $.ajax({
        type: "GET",
        url: url,
        headers: { "X-Requested-With": "XMLHttpRequest" }, // important
        success: function (res) {
            $("#transaction-list").html(res);

            // Close modal if open
            $("#form-modal .modal-body").html("");
            $("#form-modal .modal-title").html("");
            $("#form-modal").modal("hide");
        },
        error: function (err) {
            console.error("AJAX error:", err);
            alert("Failed to load transaction list.");
        }
    });
};
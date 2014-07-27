

/*BEGIN: Make modal height fit window and make it scrollable*/
$(document).ready(ajustamodal);
$(window).resize(ajustamodal);
function ajustamodal() {
    var altura = $(window).height() - 170; //value corresponding to the modal heading + footer
    $(".ativa-scroll").css({ "height": altura, "overflow-y": "auto" });
}
/*END: Make modal height fit window and make it scrollable*/


/*BEGIN: Fill Test values in the form. Takes random number and append it to form field name.*/
var fillTestValues = function (context) {
    var rnd = Math.ceil(Math.random() * 100);

    $('#' + context + ' input').val(function () {
        return this.name + " " + rnd;
    });
}
/*BEGIN: Fill Test values in the form. Takes random number and append it to form field name.*/






/*Begin: Shortcuts*/
var shortcutOptions = {
    'type': 'keydown',
    'propagate': true,
    'target': document,
    'disable_in_input': true
};

shortcut.add('0', function () {
    $('body').toggleClass('page-quick-sidebar-open');
}, shortcutOptions);

shortcut.add('Alt+1', function () {
    $('#tbl1_filter').toggle();
    $('#tbl1_AdvancedSearch').toggle();
    $('#tbl1_filter *:input[type!=hidden]:first, #tbl1_AdvancedSearch *:input[type!=hidden]:first').focus();
});

shortcut.add('Q', function () {
    fillTestValues('DefaultForm');
}, shortcutOptions);
/*End: Shortcuts*/
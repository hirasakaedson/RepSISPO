
function mostrarModal() {
    
   $('#buscarCursoModal').show();


}


function fecharModal() {
    
        $('#buscarCursoModal').hide();
  
}


function receberValorModal() {

    var valor = $('option:selected').val();
    $("#hfCursoID").val(valor)
    //$("#cursoSelecionadoID").val(valor)
    var str = "";
    $("select option:selected").each(function () {
        str += $(this).text() + " ";
        $("#txtBuscaCurso").val(str);
    });

    
    
}
import React from "react";

function somma(props) {
    return props.numero.a + props.numero.b
}

function prodotto(props){
    return props.numero.a * props.numero.b
}

export { prodotto, somma };
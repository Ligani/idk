import React from "https://esm.sh/react@19?dev";
import ReactDOM from "https://esm.sh/react-dom@19/client?dev";

const Foo = (props)=>{
    return(<div>
        <div>имя: {props.Name} </div>
        <div>Возраст: {props.Age} </div>
    </div>)
}

ReactDOM.createRoot(
    document.getElementById("app")
).render(
    <Foo Name="ktoto" Age="1444"/>
)
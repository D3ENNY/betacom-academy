import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";

import App from "../App"
import GetData from "./getData";
import { First } from "./First";
import { UseServices } from "./First";
import { Somma } from "./FirstMulti";
import { Prodotto } from "./FirstMulti";
import tsvc from "../services/TestServices";
import HookGetData from "../Hook/HookGetData";

const MyMenu = () => {
    const divStyle = {
        display: 'flex',
        gap: 10,
        listStyleType: 'none'
    }
    return (
        <Router>
            <div style={divStyle}>
                <li>
                    <Link to="/">HOME</Link>
                </li>
                <li>
                    <Link to="/first">first</Link>
                </li>
                <li>
                    <Link to="/somma">somma</Link>
                </li>
                <li>
                    <Link to="/prodotto">prodotto</Link>
                </li>
                <li>
                    <Link to="/fetch">fetch</Link>
                </li>
                <li>
                    <Link to="/service">service</Link>
                </li>
                <li>
                    <Link to="/hook">hook</Link>
                </li>
            </div>

            <Routes>
                <Route path="/" element={<App />} />
                <Route path="/first" element={<First />} />
                <Route path="/somma" element={<Somma numero={{ a:5, b:7 }} />} />
                <Route path="/prodotto" element={<Prodotto numero={{ a:5, b:7 }} />} />
                <Route path="/fetch" element={<GetData />} />
                <Route path="/service" element={<UseServices  Tservice={tsvc}/>} />
                <Route path="/hook" element={<HookGetData/>} />
            </Routes>

        </Router>

    )
}

export default MyMenu
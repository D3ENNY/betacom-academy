import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";

import First from "./First";
import App from "../App"
import GetData from "./getData";

const MyMenu = () => {
    return (
        <Router>

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

            <Routes>
                <Route path="/" element={<App />} />
                <Route path="/first" element={<First />} />
                <Route path="/somma" element={<somma numero={{ a:5, b:7 }} />} />
                <Route path="/prodotto" element={<prodotto numero={{ a:5, b:7 }} />} />
                <Route path="/fetch" element={<GetData />} />
            </Routes>

        </Router>

    )
}

export default MyMenu
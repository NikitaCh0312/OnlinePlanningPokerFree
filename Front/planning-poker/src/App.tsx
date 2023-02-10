import { Routes, Route, Link } from "react-router-dom";
import { AboutView } from "./view/AboutView/AboutView";
import { GameView } from "./view/GameView/GameView";
import { Layout } from "./view/Layout/Layout";
import { LoginView } from "./view/LoginView/LoginView";

export default function App() {
  return (
    <div style={{ margin: 0 }}>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<LoginView />} />
          <Route path="game" element={<GameView />} />
          <Route path="about" element={<AboutView />} />
          <Route path="*" element={<NoMatch />} />
        </Route>
      </Routes>
    </div>
  );
}

function NoMatch() {
  return (
    <div>
      <h2>Nothing to see here!</h2>
      <p>
        <Link to="/">Go to the home page</Link>
      </p>
    </div>
  );
}

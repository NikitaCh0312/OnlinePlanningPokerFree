import { Button } from "@mui/material";
import { Outlet, useNavigate } from "react-router-dom";

export function Layout(): JSX.Element {
  const navigate = useNavigate();
  const handleOnClick = () => {
    navigate("about");
  };
  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        minHeight: "100vh",
      }}
    >
      <nav>
        <h1>Planning poker online</h1>
        <Button onClick={handleOnClick}>О сервисе</Button>
      </nav>
      <hr />

      <div
        style={{
          flex: "1",
          height: "100%",
          minHeight: "100vh",
        }}
      >
        <Outlet />
      </div>
      <Footer></Footer>
    </div>
  );
}

const Footer = () => (
  <footer>
    <hr />
    <div className="row">
      <p>Phone: +1 (XXX) XXX-XXXX</p>
      <p>Email: XXXXX@XXXXX.com</p>
      <p>Follow me on:</p>
    </div>
  </footer>
);

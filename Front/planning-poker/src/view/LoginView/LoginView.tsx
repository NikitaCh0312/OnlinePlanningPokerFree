import { Button, TextField, Typography } from "@mui/material";
import { Link, useNavigate } from "react-router-dom";

export function LoginView(): JSX.Element {
  const navigate = useNavigate();

  const handleOnClick = () => {
    navigate("/game");
  };
  return (
    <div
      style={{
        height: "100%",
        backgroundColor: "#454545",
        justifyContent: "center",
        alignItems: "center",
        display: "flex",
      }}
    >
      <Typography>Planning poker</Typography>
      <Button sx={{ backgroundColor: "#FF0000" }} onClick={handleOnClick}>
        {" "}
        Создать новую игру
      </Button>
      <Typography>Game test</Typography>
      <div>
        <Link to="/game">Game</Link>
      </div>
      <Typography>Подключиться к игре</Typography>
      <TextField></TextField>
    </div>
  );
}

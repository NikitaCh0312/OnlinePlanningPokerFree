import { Button, TextField, Typography } from "@mui/material";
import { useNavigate } from "react-router-dom";

export function GameView(): JSX.Element {
  const navigate = useNavigate();

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
      <Typography>Game View</Typography>
      <Typography>Vote</Typography>
      <TextField></TextField>
    </div>
  );
}

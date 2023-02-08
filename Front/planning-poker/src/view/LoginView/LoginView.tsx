import { Button, TextField, Typography } from "@mui/material";

export function LoginView(): JSX.Element {
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
      <Button sx={{ backgroundColor: "#FF0000" }}> Создать новую игру</Button>
      <Typography>Подключиться к игре</Typography>
      <TextField></TextField>
    </div>
  );
}

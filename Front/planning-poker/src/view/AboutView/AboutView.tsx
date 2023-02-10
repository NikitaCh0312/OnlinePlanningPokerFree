import { Button, Typography } from "@mui/material";
import { useNavigate } from "react-router-dom";

export function AboutView(): JSX.Element {
  const navigate = useNavigate();
  const handleOnClick = () => {
    navigate("/");
  };
  return (
    <div>
      <Button onClick={handleOnClick}>На главную</Button>
      <Typography>О сервисе</Typography>
    </div>
  );
}

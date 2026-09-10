import { Fragment, useEffect, useState } from "react"
import { List, ListItem, ListItemText, Typography } from "@mui/material";

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  
  useEffect(() => {
    fetch("https://localhost:5001/api/v1/events")
    .then(response => response.json())
    .then(data => setActivities(data))

    return () => {};
  }, []);

  return (
    <Fragment> 
      <Typography variant="h3" style={{ color: "coral" }}>
        Events Hub
      </Typography>
      <List>
        {activities.map((activity: Activity) => (
          <ListItem key={activity.id}>
            <ListItemText>{activity.title}</ListItemText> 
          </ListItem>
        ))}
      </List>
    </Fragment>
  )
}

export default App
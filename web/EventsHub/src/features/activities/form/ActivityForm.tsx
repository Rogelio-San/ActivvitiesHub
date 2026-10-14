import { Box, Button, Paper, TextField, Typography } from "@mui/material";
import type { FormEvent } from "react";

type Props = {
    closeForm: () => void;
    activity?: Activity;
}

export default function ActivityForm({ activity, closeForm }: Props) {
    const handleSubmit = (event: FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        //console.log(event);

        const formData = new FormData(event.currentTarget);
        const data: { [key: string]: FormDataEntryValue } = {};
        formData.forEach((value, key) => {
            data[key] = value;
        });
        
    }
  return (
    <Paper sx={{ borderRadius: 3, padding: 2 }}>
        <Typography variant="h5" gutterBottom color="text.primary">
            Create Activity
        </Typography>
        <Box component="form" onSubmit={handleSubmit} sx={{ display: 'flex', flexDirection: 'column', gap: 3 }}>
            <TextField name="title" label="Title" defaultValue={activity?.title} />
            <TextField name="description" label="Description" defaultValue={activity?.description} multiline rows={3} />
            <TextField name="category" label="Category" defaultValue={activity?.category} />
            <TextField name="date" label="Date" type="date" defaultValue={activity?.date} />
            <TextField name="city" label="City" defaultValue={activity?.city} />
            <TextField name="venue" label="Venue" defaultValue={activity?.venue} />
            <Box sx={{ display: 'flex', justifyContent: 'end', gap: 3 }}>
                <Button onClick={closeForm} color="inherit">Cancel</Button>
                <Button type="submit" color="success" variant="contained" >
                    Submit
                </Button>
            </Box>
        </Box>
    </Paper>
  )
}

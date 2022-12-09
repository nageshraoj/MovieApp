import axios from "axios";
import React, { useState, useEffect } from "react";
import {
  Card,
  CardHeader,
  Container,
  Avatar,
  CardContent,
  CardMedia,
  Typography,
  CardActions,
  Button,
  IconButton,
} from "@mui/material";
import { Edit, Visibility, ShoppingCart } from "@mui/icons-material";

import { red } from "@mui/material/colors";

const MovieCategory = [
  "Horror",
  "Comedy",
  "Triller",
  "Drama",
  "Fantacy",
  "Cartoon",
  "Documentary",
  "Action",
];

const formatter = new Intl.NumberFormat("en-US", {
  style: "currency",
  currency: "USD",
});

const Movies = () => {
  const [movies, setMovies] = useState<any>();

  useEffect(() => {
    const getActors = async () => {
      const { data }: any = await axios.get("http://localhost:5005/api/Movie");
      setMovies(data);

      return data;
    };
    getActors();
  }, []);

  return (
    <>
      <Container sx={{ display: "flex", flexWrap: "wrap" }}>
        {movies?.map((item: any, index: any) => (
          <Card
            key={index}
            sx={{
              width: 350,
              margin: 1.5,
              cursor: "pointer",
              transition: "all 0.3s ease",
              "&:hover": {
                transform: "scale(1.1)",
              },
            }}
          >
            <CardHeader
              sx={{ height: 50 }}
              avatar={
                <Avatar sx={{ bgcolor: red[500] }} aria-label="recipe">
                  {item.name.charAt(0)}
                </Avatar>
              }
              action={
                <IconButton aria-label="settings">
                  <Edit />
                </IconButton>
              }
              title={item.name}
            />
            <div style={{ display: "flex" }}>
              <CardMedia
                component="img"
                height="250"
                image={item.imageURL}
                alt="Paella dish"
              />
              <CardContent>
                <Typography variant="body2" color="text.secondary">
                  {item.description}
                </Typography>
                <Typography
                  variant="body2"
                  sx={{ fontSize: 12 }}
                  color="text.secondary"
                >
                  <b>Start Date:</b>
                  {item.startDate instanceof Date
                    ? item.startDate.toDateString()
                    : new Date(item.startDate).toDateString()}
                </Typography>

                <Typography
                  variant="body2"
                  sx={{ fontSize: 12 }}
                  color="text.secondary"
                >
                  <b>End Date:</b>
                  {item.endDate instanceof Date
                    ? item.endDate.toDateString()
                    : new Date(item.endDate).toDateString()}
                </Typography>
                <Typography
                  variant="body2"
                  sx={{ fontSize: 12 }}
                  color="text.secondary"
                >
                  <b>Catagory:</b>
                  {MovieCategory[item.movieCategory]}
                </Typography>

                <Typography
                  variant="body2"
                  sx={{ fontSize: 12 }}
                  color="text.secondary"
                >
                  <b>Available: </b>
                  {Date.now() >= Date.parse(item.startDate) &&
                  Date.now() <= Date.parse(item.endDate) ? (
                    <span
                      style={{
                        backgroundColor: "green",
                        borderRadius: "5px",
                        padding: "0px 5px",
                        fontSize: "10px",
                        color: "#fff",
                      }}
                    >
                      Available
                    </span>
                  ) : Date.now() > Date.parse(item.endDate) ? (
                    <span
                      style={{
                        backgroundColor: "#FF7000",
                        borderRadius: "5px",
                        padding: "0px 5px",
                        fontSize: "10px",
                        color: "#fff",
                      }}
                    >
                      Expired
                    </span>
                  ) : (
                    <span
                      style={{
                        backgroundColor: "#28a8d3",
                        borderRadius: "5px",
                        padding: "0px 5px",
                        fontSize: "10px",
                        color: "#fff",
                      }}
                    >
                      Upcoming
                    </span>
                  )}
                </Typography>
              </CardContent>
            </div>
            <CardActions>
              <Button
                variant="contained"
                sx={{
                  fontSize: "10px",
                  backgroundColor: "#28a8d3",
                  borderRadius: "5px",
                  "&:hover": {
                    backgroundColor: "#28a8d3",
                  },
                  "&:active": {
                    transform: "scale(.9)",
                  },
                }}
                startIcon={<ShoppingCart />}
              >
                Add to Cart (Price {formatter.format(item.price)})
              </Button>
              <Button
                variant="contained"
                sx={{
                  fontSize: "10px",
                  backgroundColor: "#FF7000",
                  borderRadius: "5px",
                  "&:hover": {
                    backgroundColor: "#FF7000",
                  },
                  "&:active": {
                    transform: "scale(.9)",
                  },
                }}
                startIcon={<Visibility />}
              >
                Show Details
              </Button>
            </CardActions>
          </Card>
        ))}
      </Container>
    </>
  );
};

export default Movies;

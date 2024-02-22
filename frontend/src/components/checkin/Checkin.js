import * as React from 'react';
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import FormControl from '@mui/material/FormControl';
import InputLabel from '@mui/material/InputLabel';
import Select from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';
import { useState } from 'react';
import ArrowDropUpRoundedIcon from '@mui/icons-material/ArrowDropUpRounded';
import ArrowDropDownRoundedIcon from '@mui/icons-material/ArrowDropDownRounded';
import Input from '@mui/material/Input';
import InputAdornment from '@mui/material/InputAdornment';
import IconButton from '@mui/material/IconButton';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';

import dayjs from 'dayjs';
import { DemoContainer, DemoItem } from '@mui/x-date-pickers/internals/demo';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { DesktopDatePicker } from '@mui/x-date-pickers/DesktopDatePicker';
import { MobileDatePicker } from '@mui/x-date-pickers/MobileDatePicker';


import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import SendIcon from '@mui/icons-material/Send';
import Stack from '@mui/material/Stack';

export default function Checkin() {
    const [petType, setPetType] = React.useState('');
    const [count, setCount] = useState(0);

    const handleChange = (event) => {
        setPetType(event.target.value);
    };

    // Event handler for incrementing count
    const increment = () => {
        setCount(count + 1);
    };

    // Event handler for decrementing count
    const decrement = () => {
        if (count > 0) {
            setCount(count - 1);
        }
    };

    return (
        <Box>
            <Card variant="outlined"  
            sx={{ 
                backgroundColor: 'SeaShell' , 
                borderRadius: '20px',
                width:'100', 
                margin:2 
                }}>
                <CardContent>
                    <Row>
                    <Col>
                        <Typography variant="h5" component="div">
                            Online Reservation
                        </Typography>
                    </Col>
                    </Row><hr/>
                    <Row className='mt-3'>
                        <Col  xs={12} md={6}>
                            <FormControl sx={{ mt: 2, minWidth: 120 }} size="small">
                                <InputLabel id="pet-type-label">Pet Type</InputLabel>
                                <Select
                                    labelId="pet-type-label"
                                    id="pet-type-select"
                                    value={petType}
                                    onChange={handleChange}
                                    label="Pet Type"
                                >
                                    <MenuItem value="">
                                        <em>None</em>
                                    </MenuItem>
                                    <MenuItem value="Cat">Cat</MenuItem>
                                    <MenuItem value="Dog">Dog</MenuItem>
                                </Select>
                            </FormControl>
                        </Col>
                        <Col  xs={12} md={6}><FormControl sx={{ mt: 2, minWidth: 120 }}>
                        <InputLabel htmlFor="count-input">Guests</InputLabel>
                        <Input
                            id="count-input"
                            value={count}
                            onChange={(e) => setCount(parseInt(e.target.value) || 0)}
                            endAdornment={
                                <InputAdornment position="end">
                                    <IconButton
                                        aria-label="Increment count"
                                        onClick={increment}
                                    >
                                    <ArrowDropUpRoundedIcon />
                                    </IconButton>
                                    <IconButton
                                        aria-label="Decrement count"
                                        onClick={decrement}
                                    >
                                        <ArrowDropDownRoundedIcon />
                                    </IconButton>
                                </InputAdornment>
                            }
                            type="number"
                        />
                    </FormControl>
                        </Col>
                    </Row>

                    <Row className='mt-3'>
                        <Col  xs={12} md={6}>
                        
                            <LocalizationProvider dateAdapter={AdapterDayjs}>
                            <DemoContainer
                                components={['DatePicker', 'DesktopDatePicker', 'MobileDatePicker']}
                            >
                                <DemoItem label="Check In">
                                <DatePicker defaultValue={dayjs('2024-02-10')} />
                                </DemoItem>
                            </DemoContainer>
                            </LocalizationProvider>
                        </Col>
                        <Col>
                        
                            <LocalizationProvider dateAdapter={AdapterDayjs}>
                            <DemoContainer
                                components={['DatePicker', 'DesktopDatePicker', 'MobileDatePicker']}
                            >
                                <DemoItem label="Check Out">
                                <DatePicker defaultValue={dayjs('2024-02-10')} />
                                </DemoItem>
                            </DemoContainer>
                            </LocalizationProvider>
                        </Col>
                    </Row>
                    <Row className='mt-3'>
                    <Col xs={12}>
                        <Button variant="contained" endIcon={<SendIcon />} 
                        style={{ display: 'block', margin: 'auto' }}>
                            Check Availability
                        </Button>
                    </Col>
                    </Row>
                    
                </CardContent>
            </Card>
        </Box>
    );
}

import * as React from 'react';
import ImageList from '@mui/material/ImageList';
import ImageListItem from '@mui/material/ImageListItem';

function srcset(image, size, rows = 1, cols = 1) {
  return {
    src: `${image}?w=${size * cols}&h=${size * rows}&fit=crop&auto=format`,
    srcSet: `${image}?w=${size * cols}&h=${
      size * rows
    }&fit=crop&auto=format&dpr=2 2x`,
  };
}

export default function Gallery() {
  return (
    <div style={{ display: 'flex', justifyContent: 'center' }}>
      <ImageList
        sx={{ width: 'auto', height: 'auto', borderRadius: 8, overflow: 'hidden' }}
        variant="quilted"
        cols={4}
        rowHeight={121}
      >
        {itemData.map((item) => (
          <ImageListItem key={item.img} cols={item.cols || 1} rows={item.rows || 1}>
            <img
              {...srcset(item.img, 121, item.rows, item.cols)}
              alt={item.title}
              loading="lazy"
              style={{ borderRadius: 'inherit', width: '100%', height: '100%' }}
            />
          </ImageListItem>
        ))}
      </ImageList>
    </div>
  );
}

const itemData = [
  {
    img: '../../assets/9.avif',
    title: 'Breakfast',
    rows: 2,
    cols: 2,
  },
  {
    img: '../../assets/c2.jpg',
    title: 'Burger',
  },
  {
    img: '../../assets/4.jpg',
    title: 'Camera',
  },
  {
    img: '../../assets/6.webp',
    title: 'Coffee',
    cols: 2,
  },
  {
    img: '../../assets/c3.webp',
    title: 'Hats',
    cols: 2,
  },
  {
    img: '../../assets/c1.jpg',
    title: 'Hats',
    cols: 2,
  },
];

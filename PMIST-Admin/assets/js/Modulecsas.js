

   export function showImage(imageUrl) {
        Swal.fire({
            html: `
                <div style="position: relative;">
                    <div class="btn-close-icon" onclick="Swal.close()" style="cursor: pointer; position: absolute; top: -15px; right: -25px;">&times;</div>
                    <h2 class="fw-bold">Thumbnail Image</h2>
                    <img src="${imageUrl}" alt="Image Preview" class="image-preview img-fluid mt-3" id="popupImage">
                </div> 
        `,
            showConfirmButton: false, /* Removes the OK button */
            //background: '#f9f9f9',
            //width: '50%', /* Adjust popup width as needed */
            //customClass: {
            //    popup: 'sweet-popup-style',
            //},
        });
    }



    // Function to open the modal
  export function openModal() {
        document.getElementById('fileUploaderModal').style.display = 'block';
    }

    // Function to close the modal
  export  function closeModal() {
        document.getElementById('fileUploaderModal').style.display = 'none';
    }


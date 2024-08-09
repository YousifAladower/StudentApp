using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Modules.Domain;
using StudentApp.Modules.Dto;
using StudentApp.Repository.Interface;

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }
        [HttpPost]
        public async Task<IActionResult> creatStudentpost(StudentAddDto requesDto)
        {
            //convert Dto to Domain
            var student = _mapper.Map<Student>(requesDto);



            var reponse = await _studentRepository.creatStudentAsync(student);

            var studentResponseDto = _mapper.Map<StudentResponseDto>(reponse);
            return Ok(studentResponseDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> getBlogpostByID([FromRoute] int id)
        {
            var student = await _studentRepository.geStudenttByIDAsync(id);

            if (student is null)
            {
                return NotFound();
            }
            var studentResponseDto = _mapper.Map<StudentResponseDto>(student);
            return Ok(studentResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> editBlogpost(StudentUpdateDto updateStudent)
        {
            //convert Dto to Domian 
            var student = _mapper.Map<Student>(updateStudent);



            var studentResponse = await _studentRepository.editStudentAsync(student);
            if (studentResponse == null)
            {
                return NotFound();
            }
            //convert Domain to Dto
            var studentResponseDto = _mapper.Map<StudentResponseDto>(student);
            return Ok(studentResponseDto);

        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> deleteBlogpost([FromRoute] int id)
        {
            var deletedStudent = await _studentRepository.deleteStudentAsync(id);
            if (deletedStudent == null)
            {
                NotFound();
            }
            var studentResponseDto = _mapper.Map<StudentResponseDto>(deletedStudent);
            return Ok(studentResponseDto);
        }
    }
}

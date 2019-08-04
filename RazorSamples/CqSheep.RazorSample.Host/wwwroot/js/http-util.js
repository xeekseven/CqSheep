
/** jq http get请求 
 * @param baseUrl 不带参数的url
 * @param paramKV 参数对象 应该是一个object对象
 * @param callback 回调函数
*/

function httpGet(baseUrl,paramObj,successFunc,errorFunc = undefined){
    let paramText = ""
    for(let key in paramObj){
        paramText = `${paramText}&${key}=${paramObj[key]}`
    }
    paramText = paramText.replace(/^&/g,'')
    let realUrl = baseUrl + '?' + paramText
    $.ajax({
        url:realUrl,
        type:'get',
        dataType:'json',
        success:function(data){
            successFunc(data)
        },
        error:function(error){
            if(errorFunc){
                errorFunc(error)
            }
            else{
                throw(error)
            }
        }
    })
}

/**
 * jq http post 使用json格式访问的Post方法
 * @param {*} baseUrl 不带参数的url
 * @param {*} paramObj 参数对象 应该是一个object对象
 * @param {*} callback 回调函数
 */
function httpPostWithJson(baseUrl,paramObj,successFunc,errorFunc = undefined){
    $.ajax({
        url:baseUrl,
        type:'post',
        dataType:'json',
        contentType: "application/json;charset=UTF-8",
        data:JSON.stringify(paramObj),
        success:function(data){
            successFunc(data)
        },
        error:function(error){
            if(errorFunc){
                errorFunc(error)
            }
            else{
                throw(error)
            }
        }
    })
}

function httpPostWithForm(baseUrl,paramObj,callback){

}